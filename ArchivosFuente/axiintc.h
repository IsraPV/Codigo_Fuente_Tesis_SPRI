
#ifndef AXIINT_H
#define AXIINT_H

#include <stdint.h>
#include "baseaddress.h"

/*  Definición de registros del controlador de interrupciones */
#define INTC_IS_R	(*((volatile uint32_t *)(INT_CONT_BA + 0x000)))
#define INTC_IP_R	(*((volatile uint32_t *)(INT_CONT_BA + 0x004)))
#define INTC_IE_R	(*((volatile uint32_t *)(INT_CONT_BA + 0x008)))
#define INTC_ACK_R	(*((volatile uint32_t *)(INT_CONT_BA + 0x00C)))
#define INTC_SIE_R 	(*((volatile uint32_t *)(INT_CONT_BA + 0x010)))
#define INTC_CIE_R 	(*((volatile uint32_t *)(INT_CONT_BA + 0x014)))
#define INTC_IV_R 	(*((volatile uint32_t *)(INT_CONT_BA + 0x018)))
#define INTC_ME_R 	(*((volatile uint32_t *)(INT_CONT_BA + 0x01C)))
#define INTC_IM_R 	(*((volatile uint32_t *)(INT_CONT_BA + 0x020)))
#define INTC_IL_R 	(*((volatile uint32_t *)(INT_CONT_BA + 0x024)))

#define INTC_IVA0_R (*((volatile uint32_t *)(INT_CONT_BA + 0x100)))
#define INTC_IVA1_R (*((volatile uint32_t *)(INT_CONT_BA + 0x104)))
#define INTC_IVA2_R (*((volatile uint32_t *)(INT_CONT_BA + 0x108)))
#define INTC_IVA3_R (*((volatile uint32_t *)(INT_CONT_BA + 0x10C)))
#define INTC_IVA4_R (*((volatile uint32_t *)(INT_CONT_BA + 0x110)))
#define INTC_IVA5_R (*((volatile uint32_t *)(INT_CONT_BA + 0x114)))
#define INTC_IVA6_R (*((volatile uint32_t *)(INT_CONT_BA + 0x118)))
#define INTC_IVA7_R (*((volatile uint32_t *)(INT_CONT_BA + 0x11C)))
#define INTC_IVA8_R (*((volatile uint32_t *)(INT_CONT_BA + 0x120)))
#define INTC_IVA9_R (*((volatile uint32_t *)(INT_CONT_BA + 0x124)))

#define INTC_IVA_B	(INT_CONT_BA + 0x0100)

/*	Declaración de funciones	*/
void setInterrupt(uint8_t int_num, void* handler_int);


#endif

