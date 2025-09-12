// #include "hal/hal_gpio.h"
// #include "../config/pin_config.h"
// #include <util/delay.h>

// int main(void) {
//     HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
//     HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);

//     *(BUTTON_PORT) |= (1 << BUTTON_PIN);

//     uint8_t led_state = 0;
//     uint8_t last_button_state = 1;  // pull-up means idle state is HIGH

//     while (1) {
//         uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

//         // Simple debounce and edge detection
//         if (button_state && !last_button_state) {
//             led_state = !led_state;
//             HAL_GPIO_Write(LED_PORT, LED_PIN, led_state);
//             _delay_ms(50);  // debounce delay
//         }

//         last_button_state = button_state;
//         _delay_ms(10);  // polling delay
//     }
// }    
#include "hal/hal_gpio.h"
#include "../config/pin_config.h"
#include <util/delay.h>

// Define modes
#define MODE_1_SLOW_BLINK 0
#define MODE_2_FAST_BLINK 1
#define MODE_3_STAYS_ON   2
#define NUM_MODES         3

// Define blink delays (in polling cycles)
#define SLOW_BLINK_CYCLES 100  // 100 * 10ms = 1000ms
#define FAST_BLINK_CYCLES 25   // 25 * 10ms = 250ms
#define DEBOUNCE_DELAY 50
#define POLLING_DELAY 10

int main(void) {
    HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);

    // Enable pull-up resistor for button
    *(BUTTON_PORT) |= (1 << BUTTON_PIN);

    uint8_t current_mode = MODE_1_SLOW_BLINK;
    uint8_t last_button_state = 1;  // pull-up means idle state is HIGH
    uint16_t cycle_counter = 0;

    while (1) {
        uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

        // Button press detection with debouncing
        if (button_state == 0 && last_button_state == 1) {
            _delay_ms(DEBOUNCE_DELAY);
            // Check button again after debounce
            button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);
            if (button_state == 0) {  // Button is still pressed
                // Cycle to next mode
                current_mode = (current_mode + 1) % NUM_MODES;
                
                // If switching to mode 3, turn LED on immediately
                if (current_mode == MODE_3_STAYS_ON) {
                    HAL_GPIO_Write(LED_PORT, LED_PIN, 1);
                }
                
                // Reset cycle counter when mode changes
                cycle_counter = 0;
                
                // Wait for button release
                while (HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN) == 0) {
                    _delay_ms(POLLING_DELAY);
                }
                _delay_ms(DEBOUNCE_DELAY);  // Additional debounce after release
            }
        }
        
        last_button_state = button_state;

        // Handle LED based on current mode
        switch (current_mode) {
            case MODE_1_SLOW_BLINK:
                if (cycle_counter % SLOW_BLINK_CYCLES == 0) {
                    HAL_GPIO_Toggle(LED_PORT, LED_PIN);
                }
                break;
                
            case MODE_2_FAST_BLINK:
                if (cycle_counter % FAST_BLINK_CYCLES == 0) {
                    HAL_GPIO_Toggle(LED_PORT, LED_PIN);
                }
                break;
                
            case MODE_3_STAYS_ON:
                // LED stays on, no action needed
                break;
        }
        
        _delay_ms(POLLING_DELAY);
        cycle_counter++;
        
        // Prevent overflow of cycle_counter
        if (cycle_counter > 60000) cycle_counter = 0;
    }
}