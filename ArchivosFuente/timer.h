#ifndef TIMER_H
#define TIMER_H

#include <stdint.h>

#define FREQSYSHZ	48000000
#define N_1ms		FREQSYSHZ/1000
#define N_1us		FREQSYSHZ/1000000
#define N_delay		500

#define TIMER0_INT	0x04
#define TIMER1_INT	0x05
#define WDT_INT1	0x00
#define WDT_INT2	0x01

/*	Timer 0	*/
#define TIMER_0_CS0_R		(*((volatile uint32_t *)(TIMER_0_BA + 0x00)))
#define TIMER_0_LOAD0_R		(*((volatile uint32_t *)(TIMER_0_BA + 0x04)))
#define TIMER_0_COUNT0_R	(*((volatile uint32_t *)(TIMER_0_BA + 0x08)))
#define TIMER_0_CS1_R		(*((volatile uint32_t *)(TIMER_0_BA + 0x10)))
#define TIMER_0_LOAD1_R		(*((volatile uint32_t *)(TIMER_0_BA + 0x14)))
#define TIMER_0_COUNT1_R	(*((volatile uint32_t *)(TIMER_0_BA + 0x18)))

/*	Timer 1	*/
#define TIMER_1_CS0_R		(*((volatile uint32_t *)(TIMER_1_BA + 0x00)))
#define TIMER_1_LOAD0_R		(*((volatile uint32_t *)(TIMER_1_BA + 0x04)))
#define TIMER_1_COUNT0_R	(*((volatile uint32_t *)(TIMER_1_BA + 0x08)))
#define TIMER_1_CS1_R		(*((volatile uint32_t *)(TIMER_1_BA + 0x10)))
#define TIMER_1_LOAD1_R		(*((volatile uint32_t *)(TIMER_1_BA + 0x14)))
#define TIMER_1_COUNT1_R	(*((volatile uint32_t *)(TIMER_1_BA + 0x18)))

/*WDT 0*/
#define WDT_TWCRS0_R		(*((volatile uint32_t *)(WDT_BA + 0x00)))
#define WDT_TWCRS1_R		(*((volatile uint32_t *)(WDT_BA + 0x04)))
#define WDT_TBR_R			(*((volatile uint32_t *)(WDT_BA + 0x08)))
#define WDT_MWR_R			(*((volatile uint32_t *)(WDT_BA + 0x0C)))
#define WDT_ESR_R			(*((volatile uint32_t *)(WDT_BA + 0x10)))
#define WDT_FCR_R			(*((volatile uint32_t *)(WDT_BA + 0x14)))
#define WDT_FWR_R			(*((volatile uint32_t *)(WDT_BA + 0x18)))
#define WDT_SWR_R			(*((volatile uint32_t *)(WDT_BA + 0x1C)))
#define WDT_TSR0_R			(*((volatile uint32_t *)(WDT_BA + 0x20)))
#define WDT_TSR1_R			(*((volatile uint32_t *)(WDT_BA + 0x24)))
#define WDT_STR_R			(*((volatile uint32_t *)(WDT_BA + 0x28)))

/*	Declaración de funciones del timer	*/
void setTimer0ReloadMode(uint32_t n);
uint8_t timeOutTimer0(void);
void restartTimer0(void);
void setTimer1ReloadMode(uint32_t n);
void waitTickTimer1(void);

// Declaración de funciones del watchdog
void wdtSetup(uint8_t w);
void clearResetWDT(void);
void setWdtReference(void);
uint32_t getCountsElapsedWdt(void);
double getTimeElapsedWdt(void);

/* Interrupciones */
void intHandlerTimer0(void) __attribute__ ((fast_interrupt));
void intHandlerTimer1(void) __attribute__ ((fast_interrupt));

void wdtIntHandler1(void) __attribute__ ((fast_interrupt));
void wdtIntHandler2(void) __attribute__ ((fast_interrupt));

#endif
