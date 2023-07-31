#ifndef OLED_H
#define OLED_H

#include <stdint.h>

extern const uint8_t C[128][8];

/* Declaración de funciones */
void displayOn(void);
void displayOff(void);
uint8_t isDisplayOn(void);
void displaySendCommand(uint8_t cmd);
void displaySendData(uint8_t data);
void displayConfig(void);
void setDisplayAddress(uint8_t page, uint8_t column);
void displayWrite(uint8_t data);
void displayPrint(uint8_t page, uint8_t col, const char *msg);
void displayPrintTemp(uint8_t page, uint8_t col, const char *msg, uint32_t time);
void clearDisplay(void);

#endif
