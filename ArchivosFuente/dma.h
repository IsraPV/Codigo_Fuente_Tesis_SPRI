#ifndef DMA_H
#define DMA_H

#include <stdint.h>
#include "baseaddress.h"

#define TRANSFER_COMPLETE	0x03
#define TRANSFER_ERROR		0xF0
#define WAITING_TRANSFER	0x01
#define NO_TRANSFER			0x00

#define DMA_INT			0x02

/*	Registros del DMA	*/
#define S2MM_DMAC_R		(*((volatile uint32_t *)(DMA_BA + 0x30)))
#define S2MM_DMAS_R		(*((volatile uint32_t *)(DMA_BA + 0x34)))
#define S2MM_DA_R		(*((volatile uint32_t *)(DMA_BA + 0x48)))
#define S2MM_LENGTH_R	(*((volatile uint32_t *)(DMA_BA + 0x58)))

/*	Funciones	*/
void initDMA(void);
uint32_t statusDMA(void);
void setTransferDMA(uint32_t address, uint32_t numbytes);
uint8_t transferDMAstatus(void);
void clearTransferStatusDMA(void);

/*	Interrupciones */
void dmaIntHandler(void) __attribute__ ((fast_interrupt));

#endif
