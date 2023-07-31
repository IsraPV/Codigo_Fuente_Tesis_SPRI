#include <stdint.h>

#include "Ov7670registers.h"

// Configuraciones para el módulo Ov7670
const struct RegisterData regsConfig[] = {
		{0x11, 0x01}, // Configuraci�n de reloj
		{0x6B, 0x4A}, // Configuraci�n de reloj
		{0x12, 0x04}, // RGB
		{0x40, 0xD0}, // Formato RGB 565
		{0xB0, 0x84}, // Correci�n de colores
		{0x1E, 0x31}, // Invierte verticalmente la imagen
		{0xff, 0xff},
};


const struct RegisterData regsColorBar[] = {
		{0x70, 0x3A}, // Activa el modo de prueba
		{0x71, 0xB5}, // Barra de colores como salida
		{0xff, 0xff},
};
