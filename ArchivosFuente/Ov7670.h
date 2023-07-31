#ifndef OV7670_H
#define OV7670_H

#include <stdint.h>
#include "baseaddress.h"
#include "Ov7670registers.h"

#define ST_IDLE			0x08
#define ST_END			0x02
#define OV7670_address	0x21

/* Registros del controlador CMOS	*/
#define CMOS_STS_R	(*((volatile uint32_t *)(CAM_AXI_BA + 0x08)))
#define CMOS_CTRL_R	(*((volatile uint32_t *)(CAM_AXI_BA + 0x10)))

/* Declaración de funciones */
void takeFrame(void);
void writeRegisterAddr(uint8_t reg);
void writeRegister(uint8_t reg, uint8_t data);
uint8_t readRegister(uint8_t reg);
void setRegisters(const struct RegisterData* regs);

#endif
