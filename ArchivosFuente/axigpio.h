
#ifndef AXIGPIO_H
#define AXIGPIO_H

#include <stdint.h>
#include "baseaddress.h"

/*	Registros del GPIO 0	*/
#define GPIO_0_DATA1_R	(*((volatile uint32_t *)(GPIO_0_BA + 0x000)))
#define GPIO_0_TRI1_R	(*((volatile uint32_t *)(GPIO_0_BA + 0x004)))
#define GPIO_0_DATA2_R	(*((volatile uint32_t *)(GPIO_0_BA + 0x008)))
#define GPIO_0_TRI2_R	(*((volatile uint32_t *)(GPIO_0_BA + 0x00C)))
#define GPIO_0_GIE_R	(*((volatile uint32_t *)(GPIO_0_BA + 0x11C)))
#define GPIO_0_IE_R		(*((volatile uint32_t *)(GPIO_0_BA + 0x128)))
#define GPIO_0_IS_R		(*((volatile uint32_t *)(GPIO_0_BA + 0x120)))

/*	Registros del GPIO 1	*/
#define GPIO_1_DATA1_R	(*((volatile uint32_t *)(GPIO_1_BA + 0x000)))

/*	Registros del GPIO 2	*/
#define GPIO_2_DATA1_R	(*((volatile uint32_t *)(GPIO_2_BA + 0x000)))

/*	Registros del GPIO 3	*/
#define GPIO_3_DATA1_R	(*((volatile uint32_t *)(GPIO_3_BA + 0x000)))

/*	Declaración de funciones	*/
void initGpio0(uint32_t tris);
void writeGpio0(uint32_t data);
uint32_t readGpio0(void);
uint32_t readGpio1(void);
uint32_t readGpio2(void);
void writeGpio2(uint32_t data);

#endif
