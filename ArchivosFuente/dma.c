
#include "dma.h"
#include "axiintc.h"
#include "utils.h"

uint8_t transfer_status;

void initDMA(void)
{
	// Reinicia el DMA
	S2MM_DMAC_R |= 0x04;
	// 5ms de retardo
	delay(5);

	// Poner el bit run/stop del DMA
	S2MM_DMAC_R = 0x01;

	// Espera a que el DMA se active
	while(S2MM_DMAS_R & 0x01);

	// Habilita las interrupciones (IOC_Irq_En y Err_IrqEn)
	S2MM_DMAC_R |= 0x5000;

	transfer_status = NO_TRANSFER;
}

// Devuelve el contenido del registro de estado del DMA
uint32_t statusDMA(void)
{
	return (uint32_t)S2MM_DMAS_R;
}

// Define una transferencia DMA simple
void setTransferDMA(uint32_t address, uint32_t numbytes)
{
	// Dirección destino válida
	S2MM_DA_R = address;
	// Longitud en bytes de la transferencia
	S2MM_LENGTH_R = numbytes;

	transfer_status = WAITING_TRANSFER;
}

// Devuelve el estado de la transferencia DMA
uint8_t transferDMAstatus(void)
{
	return transfer_status;
}

// Limpia el estado de la transferencia DMA
void clearTransferStatusDMA(void)
{
	transfer_status = NO_TRANSFER;
}

/*	Interrupción	*/
void dmaIntHandler(void)
{
	// ACK de la interrupción en el controlador de interrupciones
	INTC_ACK_R |= (1<<DMA_INT);
	if ((S2MM_DMAS_R & 0x5000) == 0x1000)
	{
		// Transferencia DMA completa
		transfer_status = TRANSFER_COMPLETE;
	}
	else
	{
		// Error en la transferencia DMA
		transfer_status = TRANSFER_ERROR;
	}

	// Limpia la interrupción
	S2MM_DMAS_R |= 0x5000;
}
