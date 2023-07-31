// Registers definitions for the Ov7670 CMOS

#ifndef _OV7670REGISTERS_H
#define _OV7670REGISTERS_H


struct RegisterData
{
  uint8_t addr;
  uint8_t val;
};

// Datos de configuración
extern const struct RegisterData regsConfig[];
extern const struct RegisterData regsColorBar[];



#endif
