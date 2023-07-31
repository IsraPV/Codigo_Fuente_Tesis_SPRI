
#include <stdint.h>
#include "timer.h"
#include "axiintc.h"

volatile uint8_t timeOutT0, timeOutT1;
uint32_t ref1, ref2;
uint8_t reset_wdt;

// Establece el modo reload del timer 0
void setTimer0ReloadMode(uint32_t n)
{
	TIMER_0_LOAD0_R = n;
	// Carga el valor
	TIMER_0_CS0_R = 0x20;
	TIMER_0_CS0_R = 0x52;

	timeOutT0 = 0;

	// Habilita timer 0
	TIMER_0_CS0_R |= 0x80;
}

// Devuelve el valor del timeOut del timer 0
uint8_t timeOutTimer0(void)
{
	return timeOutT0;
}

void restartTimer0(void)
{
	// Recarga el timer 0
	timeOutT0 = 0;

	TIMER_0_CS0_R = 0x20;
	TIMER_0_CS0_R = 0x52;
	TIMER_0_CS0_R |= 0x80;
}

// Establece el modo reload del timer 1
void setTimer1ReloadMode(uint32_t n)
{
	TIMER_1_LOAD0_R = n;
	// Carga valor
	TIMER_1_CS0_R = 0x20;
	TIMER_1_CS0_R = 0x52;

	timeOutT1 = 0;

	// Habilita timer 1
	TIMER_1_CS0_R |= 0x80;
}

// Espera el fin de cuenta del timer 1
void waitTickTimer1(void)
{
	while(!timeOutT1);
}

// Inicia el WDT
void wdtSetup(uint8_t w)
{
	// Establece el tamaño del registro de cuenta
	WDT_MWR_R = w;
	// Habilita el WDT con EWDT1 = 1
	WDT_TWCRS0_R = 0x02;
}

// Limpia la bandera de activación del reset del watchdog
void clearResetWDT(void)
{
	reset_wdt = 0;
}

// Establece una referencia a partir del valor de cuenta del WDT
void setWdtReference(void)
{
	ref1 = WDT_TBR_R;
}

// Número de cuentas del watchdog
uint32_t getCountsElapsedWdt(void)
{
	ref2 = WDT_TBR_R;
	if (ref2 >= ref1)
	{
		return (ref2 - ref1);
	}
	else
	{
		return (0xFFFFFFFF - ref1 + ref2);
	}
}

// Cuenta de tiempo transcurrido
double getTimeElapsedWdt(void)
{
	return (double)getCountsElapsedWdt()/FREQSYSHZ;
}

/*	Interrupciones de los temporizadores	*/
void intHandlerTimer0(void)
{
	TIMER_0_CS0_R &= ~0x80;
	TIMER_0_CS0_R |= 0x0100;
	INTC_ACK_R |= (1<<TIMER0_INT);

	timeOutT0 = 1;
}

void intHandlerTimer1(void)
{
	TIMER_1_CS0_R &= ~0x80;
	TIMER_1_CS0_R |= 0x0100;
	INTC_ACK_R |= (1<<TIMER1_INT);

	timeOutT1 = 1;
}

/* Interrupción 1 del WDT */
void wdtIntHandler1(void)
{
	INTC_ACK_R |= (1<<WDT_INT1);
	WDT_TWCRS0_R |= 0x04;
}

/* Interrupción 2 del WDT */
void wdtIntHandler2(void)
{
	INTC_ACK_R |= (1<<WDT_INT2);
	if (!reset_wdt)
	{
		// Limpia para evitar el reset
		WDT_TWCRS0_R |= 0x04;
		reset_wdt = 1;
	}
}
