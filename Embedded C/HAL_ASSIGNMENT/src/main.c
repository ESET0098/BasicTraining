#include "hal/hal_gpio.h"
#include "../config/led_config.h"
#include <util/delay.h>

#define MODE_COUNT 3

int main(void) {
    // Initialize LED pin as output
    HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
    // Initialize button pin as input with pull-up
    HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);
    // Enable internal pull-up resistor if needed
    *(BUTTON_PORT) |= (1 << BUTTON_PIN);

    uint8_t mode = 0;  // current mode
    uint8_t last_button_state = 1;  // idle state (pull-up)
    uint8_t button_pressed = 0;

    while (1) {
        uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

        // Detect button press with debounce
        if (button_state && !last_button_state) {
            // Wait for debounce
            _delay_ms(50);
            // Confirm button is still pressed
            if (HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN) == 1) {
                // Cycle to next mode
                mode = (mode + 1) % MODE_COUNT;
            }
        }
        last_button_state = button_state;

        // Perform LED behavior based on current mode
        switch (mode) {
            case 0:
                // Mode 1: Slow blink
                HAL_GPIO_Write(LED_PORT, LED_PIN, 1);
                _delay_ms(500);
                HAL_GPIO_Write(LED_PORT, LED_PIN, 0);
                _delay_ms(500);
                break;
            case 1:
                // Mode 2: Fast blink
                HAL_GPIO_Write(LED_PORT, LED_PIN, 1);
                _delay_ms(200);
                HAL_GPIO_Write(LED_PORT, LED_PIN, 0);
                _delay_ms(200);
                break;
            case 2:
                // Mode 3: LED ON
                HAL_GPIO_Write(LED_PORT, LED_PIN, 1);
                // Keep LED ON, small delay to prevent tight loop
                _delay_ms(100);
                break;
        }
    }
}
