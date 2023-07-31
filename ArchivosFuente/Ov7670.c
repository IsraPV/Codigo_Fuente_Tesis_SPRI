#include "Ov7670.h"
#include "axiiic.h"
#include "utils.h"

/* Función que inicia la toma de un fotograma*/
void takeFrame(void)
{
	// Poner en estado inicial
	CMOS_CTRL_R = 0x00;
	while(CMOS_STS_R != ST_IDLE);

	// Habilita la captura
	CMOS_CTRL_R = 0x03;
}

/* Escribe la dirección del registro del Ov7670*/
void writeRegisterAddr(uint8_t reg)
{
	// Limpia interrupciones
	I2C_0_IS_R &= 0x1C;

	// Reinicia la fifo de transmisión
	I2C_0_CTRL_R = 0x03;
	I2C_0_CTRL_R = 0x01;

	// Escribe la dirección del esclavo
	I2C_0_TXF_R = (uint8_t)(OV7670_address<<1);

	// Escribe a CR para poner MSMS = 1 y Tx = 1
	I2C_0_CTRL_R = 0x0D;

	// Espera a la interrupción de fifo de transmisión vacía
	while((I2C_0_IS_R & 0x04) == 0);

	// Limpia la interrupción
	I2C_0_IS_R &= 0x1C;

	// Escribe al CR para poner MSMS = 0
	I2C_0_CTRL_R = 0x01;
	// Escribe el último byte a la fifo de transmisión
	I2C_0_TXF_R = (uint8_t)reg;
	// Espera a la interrupción de fifo de transmisión vacía
	while((I2C_0_IS_R & 0x04) == 0);

	// Limpia las interrupciones
	I2C_0_IS_R &= 0x1C;

	// Espera a liberar el bus
	uint32_t BusyCount = 0;
	while (I2C_0_STS_R & 0x00000004)
	{
		if (BusyCount++ > 10000)
		{
			break;
		}
		delay(10);
	}
}

void writeRegister(uint8_t reg, uint8_t data)
{
	// Reinicia la fifo de transmisión
	I2C_0_CTRL_R = 0x03;
	I2C_0_CTRL_R = 0x01;

	// Escribe la dirección del esclavo a la fifo de transmisión
	I2C_0_TXF_R = (uint8_t)(OV7670_address<<1);

	// Escribe todos los datos excepto el último byte
	I2C_0_TXF_R = (uint8_t)reg;

	// Escribe a CR para poner MSMS = 1 y Tx = 1
	I2C_0_CTRL_R = 0x0D;

	// Espera a la interrupción de fifo de transmisión vacía
	while((I2C_0_IS_R & 0x04) == 0);

	// Limpia la interrupción
	I2C_0_IS_R = 0x04;
	// Escribe a CR para poner MSMS = 0
	I2C_0_CTRL_R = 0x01;
	// Escribe el último byte de datos
	I2C_0_TXF_R = (uint8_t)data;
	// Espera a la interrupción de fifo de transmisión vacía
	while((I2C_0_IS_R & 0x04) == 0);

	// Limpia la interrupción
	I2C_0_IS_R = 0x04;

	// Espera a liberar al bus
	uint32_t BusyCount = 0;
	while (I2C_0_STS_R & 0x00000004)
	{
		if (BusyCount++ > 10000)
		{
			break;
		}
		delayus(5);
	}
}

uint8_t readRegister(uint8_t reg)
{
	// Escribe la dirección del registro
	writeRegisterAddr(reg);

	// Nivel de recepción a 1 byte
	I2C_0_RX_PIRQ_R = 0;

	// Reinicia la fifo de transmisión
	I2C_0_CTRL_R = 0x03;
	I2C_0_CTRL_R = 0x01;

	// Limpia las interrupciones
	I2C_0_IS_R &= 0x1C;

	// Operación de lectura
	I2C_0_TXF_R = (uint16_t)(0x100 | OV7670_address<<1 | 0x01);
	I2C_0_TXF_R = (uint16_t)0x201;

	//Espera a que la fifo de recepción se llene
	while((I2C_0_IS_R & 0x08) == 0);

	// lee el dato o los datos
	uint8_t drx = I2C_0_RXF_R;
	while((I2C_0_STS_R & 0x40)== 0)
	{
		drx = I2C_0_RXF_R;
	}
	I2C_0_CTRL_R = 0x01;

	I2C_0_IS_R &= 0x1F;

	// Espera a liberar el bus
	uint32_t BusyCount = 0;
	while (I2C_0_STS_R & 0x00000004)
	{
		if (BusyCount++ > 10000)
		{
			break;
		}
		delay(100);
	}
	while ((I2C_0_IS_R & 0x10) != 0x10)
	{
		I2C_0_TXF_R = (uint16_t)0x200;
	}
	while ((I2C_0_STS_R & 0xC0) != 0xC0);
	return drx;
}

/* Función que establece valores de registros a partir de datos de
*  configuración almacenados en un arreglo*/
void setRegisters(const struct RegisterData* regs)
{
	const struct RegisterData *structreg;
	structreg = regs;
	while(1)
	{
		if (structreg->addr == 0xFF)
		{
			break;
		}
		else
		{
			writeRegister(structreg->addr, structreg->val);
			delayus(15);
			structreg++;
		}
	}
}


