#ifndef UTILS_H
#define UTILS_H

#include <stdint.h>

// Tablas de conversión ASCII/HEX
extern const uint8_t ASCII2HEX[24];
extern const uint8_t HEX2ASCII[16];

// Declaración de las funciones
void delay(uint32_t n);
void delayus(uint32_t n);

#endif
