
#include <stdint.h>
#include "timer.h"

/*	Retardo de n ms usando un temporizador*/
void delay(uint32_t n)
{
	setTimer1ReloadMode(N_1ms*n - N_delay);
	waitTickTimer1();
}

/* Retardo de n us usando un temporizador*/
void delayus(uint32_t n)
{
	setTimer1ReloadMode(N_1us*n);
	waitTickTimer1();
}


// Tablas de conversión
const uint8_t ASCII2HEX[24] = {
		//0		1		2		3
		0x00, 0x01, 0x02, 0x03,
		//4		5		6		7
		0x04, 0x05, 0x06, 0x07,
		//8		9	--		--
		0x08, 0x09, 0x00, 0x00,
		//--	--	--		--
		0x00, 0x00, 0x00, 0x00,
		//--	A	B		C
		0x00, 0x0A, 0x0B, 0x0C,
		//D		E	F		--
		0x0D, 0x0E, 0x0F, 0x00
};

const uint8_t HEX2ASCII[16] = {
		//0	   1     2	   3
		0x30, 0x31, 0x32, 0x33,
		//4	   5     6	   7
		0x34, 0x35, 0x36, 0x37,
		//8	   9     A	   B
		0x38, 0x39, 0x41, 0x42,
		//C	   D     E	   F
		0x43, 0x44, 0x45, 0x46
};
