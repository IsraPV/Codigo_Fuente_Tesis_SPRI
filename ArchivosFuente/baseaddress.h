#ifndef BASEADDRESS_H
#define BASEADDRESS_H

/* Este archivo contiene las definiciones de las direcciones
*  base de cada uno de los periféricos del sistema. Las cuales
*  son definidas al momento de crear la arquitectura. */

/*	GPIO	*/
#define GPIO_0_BA	0x40000000
#define GPIO_1_BA	0x40010000
#define GPIO_2_BA	0x40020000
#define GPIO_3_BA	0x40030000

/*	UART	*/
#define UARTL_0_BA	0x41000000

/*	SPI		*/
#define SPI_0_BA	0x42000000

/*	I2C		*/
#define I2C_0_BA	0x43000000

/*	Temporizador	*/
#define TIMER_0_BA	0x44000000
#define TIMER_1_BA	0x44010000

/*	CMOS	*/
#define CAM_AXI_BA	0x45000000

/*	WDT		*/
#define WDT_BA		0x46000000

/*	DMA		*/
#define DMA_BA		0x47000000

/*	Controlador de interrupciones	*/
#define INT_CONT_BA	0x48000000

/*	Memoria DDR3	*/
#define MEMDDR3		0x80000000

#endif
