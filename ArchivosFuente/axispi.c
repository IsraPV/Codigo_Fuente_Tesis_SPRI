#include <stdint.h>
#include "axispi.h"
#include "utils.h"

/* Inicializa el AXI QSPI */
void initSPI(void)
{
	// Reset por software
	SPI_0_SRST_R = 0x0000000A;
	// Retardo de 10ms
	delay(10);
	// Desactiva la selección del esclavo poniendo
	// Los valores del registro de selección en alto
	SPI_0_SSEL_R = 0xFFFFFFFF;
	// CPOL = 1,  CLK IDLE = 1, Master enable, SPI enable, CPHA = 0, MSB first, master transaction enable
	SPI_0_CTRL_R = (CPOL | MSTR | ENBL);
}

/* Transmite un dato por SPI */
void transmitSPI(uint8_t data)
{
	// Selecciona el esclavo
	SPI_0_SSEL_R &= ~0x01;
	// Escribe el dato
	SPI_0_DTX_R = data;
	// Activa la transmisión
	SPI_0_CTRL_R &= ~INNH;
	// Espera a que se complete la operación
	while((SPI_0_IS_R & 0x04) == 0);
	// Finaliza la operación, limpia la interrupción y deselecciona al
	// esclavo
	SPI_0_CTRL_R |= INNH;
	SPI_0_IS_R = 0x04;
	SPI_0_SSEL_R |= 0x01;
}
