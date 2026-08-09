#include "splashkit.h"

int main()
{
    // Open the window for the usage example
    open_window("Reading the Alpha Channel", 800, 400);

    // Three shades of magenta with different alpha (transparency) values
    color shades[] = {
        rgba_color(180, 30, 80, 64),
        rgba_color(180, 30, 80, 160),
        rgba_color(180, 30, 80, 255)
    };

    string labels[] = {
        "Low Alpha",
        "Medium Alpha",
        "Full Alpha"
    };

    while (!quit_requested())
    {
        process_events();

        // Draw the background and instructions
        clear_screen(COLOR_WHITE);
        draw_text("Alpha values for these shades", COLOR_BLACK, 240, 40);

        // Draw each shade and use alpha_of to read its alpha component
        for (int i = 0; i < 3; i++)
        {
            int value = alpha_of(shades[i]);

            fill_rectangle(shades[i], 80 + i * 240, 140, 160, 80);
            draw_text(labels[i], COLOR_BLACK, 115 + i * 240, 250);
            draw_text("Alpha: " + std::to_string(value), COLOR_BLACK, 115 + i * 240, 290);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
