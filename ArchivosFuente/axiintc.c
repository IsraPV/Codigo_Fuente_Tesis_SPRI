#include <stdint.h>
#include "axiintc.h"

/* Función que establece una interrupción en el controlador
*  de interrupciones. */
void setInterrupt(uint8_t int_num, void* handler_int)
{
	// Asigna la dirección de la rutina de interrupción al vector
	// de interrupción correspondiente en el controlador de interrupciones
	*((uint32_t *)(INTC_IVA_B + int_num*4)) = (uint32_t)handler_int;
	// Habilita la interrupción correspondiente
	INTC_IE_R |= 1<<int_num;
	// Activa las interrupciones por hardware en el controlador
	INTC_ME_R |= 0x00000003;
}
