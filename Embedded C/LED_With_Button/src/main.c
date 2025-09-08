#include <Arduino.h>
#include <util/delay.h>

#define LED_PIN PD6
#define BUTTON_PIN PD2

int main(void)
{
    DDRD |= (1 << LED_PIN);      // Set PD6 as output
    DDRD &= ~(1 << BUTTON_PIN);  // Set PD2 as input

    PORTD |= (1 << BUTTON_PIN);  // Enable pull-up resistor on PD2

    while (1) {
        // Check if button is pressed (active low)
        if (!(PIND & (1 << BUTTON_PIN))) {
            // Blink LED while button is pressed
            PORTD |= (1 << LED_PIN);  // Turn the LED on
            _delay_ms(500);
            PORTD &= ~(1 << LED_PIN); // Turn the LED off
            _delay_ms(500);
        } else {
            PORTD &= ~(1 << LED_PIN); // Ensure LED is off when button not pressed
        }
    }

    return 0;
}