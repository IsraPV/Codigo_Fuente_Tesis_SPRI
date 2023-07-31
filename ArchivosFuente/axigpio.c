#include <stdint.h>
#include "axigpio.h"

/* Definición de las funciones para los GPIO */

/* Configura cada uno de los bits del puerto 0 como entrada
*  o salida*/
void initGpio0(uint32_t tris)
{
	GPIO_0_TRI1_R = tris;
}

/* Escribe datos al puerto 0*/
void writeGpio0(uint32_t data)
{
	GPIO_0_DATA1_R = data;
}

/* Lee datos del puerto 0*/
uint32_t readGpio0(void)
{
	return (uint32_t)GPIO_0_DATA1_R;
}

/* Lee datos del puerto 1*/
uint32_t readGpio1(void)
{
	return (uint32_t)GPIO_1_DATA1_R;
}

/* Lee datos del puerto 2*/
uint32_t readGpio2(void)
{
	return (uint32_t)GPIO_2_DATA1_R;
}

/* Escribe datos al puerto 2*/
void writeGpio2(uint32_t data)
{
	GPIO_2_DATA1_R = data;
}
