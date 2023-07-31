
#ifndef AXIUARTLITE_H
#define AXIUARTLITE_H

#include <stdint.h>
#include "baseaddress.h"

#define UARTL0_INT	0x03
#define UL0BUFSIZE	64

// Declaración del buffer de transmisión y recepción
extern uint8_t UL0RXBUF[UL0BUFSIZE];
extern uint8_t UL0TXBUF[UL0BUFSIZE];

/*	Registros UART Lite 0	*/
#define UARTL_0_RXF_R	(*((volatile uint32_t *)(UARTL_0_BA + 0x00)))
#define UARTL_0_TXF_R	(*((volatile uint32_t *)(UARTL_0_BA + 0x04)))
#define UARTL_0_STS_R	(*((volatile uint32_t *)(UARTL_0_BA + 0x08)))
#define UARTL_0_CTRL_R	(*((volatile uint32_t *)(UARTL_0_BA + 0x0C)))

/*	Declaración de funciones	*/
void enableUart0(void);
void sendStringUart0(const char* s);
void transmitByte(const uint8_t b);
uint8_t bytesInRxUart0(void);
void clearBufferUart0(void);
uint8_t readRxBufferUart0(uint8_t index);
uint8_t readLastByteRxBufUart0(void);
void writeTxBufferUart0(uint8_t index, uint8_t data);
uint8_t countString(void);
uint8_t searchStringBufUart0(char *str2);

/*	Interrupciones	*/
void intHandlerUart0(void) __attribute__ ((fast_interrupt));

#endif
