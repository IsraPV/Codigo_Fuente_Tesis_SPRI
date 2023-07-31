#include <stdint.h>
#include <string.h>
#include "axiuartlite.h"
#include "axiintc.h"

// Indice del buffer de recepción
uint8_t b_i;

// Buffer de recepción y transmisión
uint8_t UL0RXBUF[UL0BUFSIZE];
uint8_t UL0TXBUF[UL0BUFSIZE];

// Habilita el UART 0
void enableUart0(void)
{
	UARTL_0_CTRL_R |= 0x10;
}

// Envía una cadena de texto por UART 0
void sendStringUart0(const char* s)
{
	while(*s)
	{
		while((UARTL_0_STS_R & 0x04)==0);
		UARTL_0_TXF_R = *s++;
	}
}

// Transmite un byte por UART 0
void transmitByte(const uint8_t b)
{
	while((UARTL_0_STS_R & 0x04)==0);
	UARTL_0_TXF_R = b;
}

// Cuenta de bytes en el buffer
uint8_t bytesInRxUart0(void)
{
	return b_i;
}

// Limpia el buffer de recepción
void clearBufferUart0(void)
{
	int i;
	for (i = 0; i < UL0BUFSIZE; i++)
	{
		UL0RXBUF[i] = 0;
	}
	b_i = 0;
}

// Lee un elemento del buffer
uint8_t readRxBufferUart0(uint8_t index)
{
	return UL0RXBUF[index];
}

// Lee el último elemento del buffer de recepción
uint8_t readLastByteRxBufUart0(void)
{
	if (b_i == 0)
		return UL0RXBUF[UL0BUFSIZE - 1];
	else
		return UL0RXBUF[b_i - 1];
}

// Escribe al buffer de transmisión
void writeTxBufferUart0(uint8_t index, uint8_t data)
{
	UL0TXBUF[index] = data;
}

// Obtiene la longitud de una cadena de texto en el buffer de recepción
uint8_t countString(void)
{
	uint8_t i = 0;
	uint8_t *p = UL0RXBUF;
	while(*p++)
	{
		i++;
	}
	return i;
}

/* Busca una cadena de texto en el buffer de recepción */
uint8_t searchStringBufUart0(char *str2)
{
	if (strstr((const char *)UL0RXBUF, str2))
		return 1;
	else
		return 0;
}

/*	Rutina de servicio de interrupción del UART 0*/
void intHandlerUart0(void)
{
	INTC_ACK_R |= 0x00000008;
	while(UARTL_0_STS_R & 0x1)
	{
		UL0RXBUF[b_i++] = UARTL_0_RXF_R;
		if (b_i >= UL0BUFSIZE)
		{
			b_i = 0;
		}
	}
}
