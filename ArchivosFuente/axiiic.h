
#ifndef AXIIIC_H
#define AXIIIC_H

#include <stdint.h>
#include "baseaddress.h"

#define I2C_TX_ERROR_MASK   0x02
#define I2C_TX_FIFO_EMPTY   0x04
#define I2C_RX_FIFO_FULL    0x08
#define I2C_BUSNOTBSY_MASK  0x10

/*	Registros I2C 0	*/
#define I2C_0_GIE_R		(*((volatile uint32_t *)(I2C_0_BA + 0x001)))
#define I2C_0_IS_R		(*((volatile uint32_t *)(I2C_0_BA + 0x020)))
#define I2C_0_IE_R		(*((volatile uint32_t *)(I2C_0_BA + 0x028)))
#define I2C_0_SRST_R	(*((volatile uint32_t *)(I2C_0_BA + 0x040)))
#define I2C_0_CTRL_R	(*((volatile uint32_t *)(I2C_0_BA + 0x100)))
#define I2C_0_STS_R		(*((volatile uint32_t *)(I2C_0_BA + 0x104)))
#define I2C_0_TXF_R		(*((volatile uint32_t *)(I2C_0_BA + 0x108)))
#define I2C_0_RXF_R		(*((volatile uint32_t *)(I2C_0_BA + 0x10C)))
#define I2C_0_SLADR_R	(*((volatile uint32_t *)(I2C_0_BA + 0x110)))
#define I2C_0_TFO_R		(*((volatile uint32_t *)(I2C_0_BA + 0x114)))
#define I2C_0_RFO_R		(*((volatile uint32_t *)(I2C_0_BA + 0x118)))
#define I2C_0_RX_PIRQ_R		(*((volatile uint32_t *)(I2C_0_BA + 0x120)))

/*	Declaración de funciones	*/
void initI2C0(void);

#endif
