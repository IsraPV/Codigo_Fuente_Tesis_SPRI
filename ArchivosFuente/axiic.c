#include "axiiic.h"

/* Inicializa el módulo AXI IIC */
void initI2C0(void)
{
	// Habilitar
	I2C_0_CTRL_R = 0x01;
	// Activar interrupciones:
	// Tx Error/Tx slave complet, Tx Fifo empty
	// Rx fifo full, bus not busy
	I2C_0_IE_R = (0x02 | 0x04 | 0x08 | 0x10);
}
