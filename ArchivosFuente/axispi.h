
#ifndef AXISPI_H
#define AXISPI_H

#include <stdint.h>
#include "baseaddress.h"

#define INNH	0x100
#define CPOL	0x08
#define MSTR	0x04
#define ENBL	0x02

/*	Registros del SPI 0	*/
#define SPI_0_SRST_R	(*((volatile uint32_t *)(SPI_0_BA + 0x40)))
#define SPI_0_CTRL_R	(*((volatile uint32_t *)(SPI_0_BA + 0x60)))
#define SPI_0_STS_R		(*((volatile uint32_t *)(SPI_0_BA + 0x64)))
#define SPI_0_DTX_R		(*((volatile uint32_t *)(SPI_0_BA + 0x68)))
#define SPI_0_DRX_R		(*((volatile uint32_t *)(SPI_0_BA + 0x6C)))
#define SPI_0_SSEL_R	(*((volatile uint32_t *)(SPI_0_BA + 0x70)))
#define SPI_0_TFO_R		(*((volatile uint32_t *)(SPI_0_BA + 0x74)))
#define SPI_0_RFO_R		(*((volatile uint32_t *)(SPI_0_BA + 0x78)))
#define SPI_0_GIE_R		(*((volatile uint32_t *)(SPI_0_BA + 0x1C)))
#define SPI_0_IS_R		(*((volatile uint32_t *)(SPI_0_BA + 0x20)))
#define SPI_0_IE_R		(*((volatile uint32_t *)(SPI_0_BA + 0x28)))

/*	Declaración de funciones del SPI 0	*/
void initSPI(void);
void transmitSPI(uint8_t data);

#endif
