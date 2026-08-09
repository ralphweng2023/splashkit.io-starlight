from splashkit import *

# Open the window for the usage example
open_window("Reading the Alpha Channel", 800, 400)

# Three shades of magenta with different alpha (transparency) values
shades = [
    rgba_color(180, 30, 80, 64),
    rgba_color(180, 30, 80, 160),
    rgba_color(180, 30, 80, 255)
]

labels = ["Low Alpha", "Medium Alpha", "Full Alpha"]

while not quit_requested():
    process_events()

    # Draw the background and instructions
    clear_screen(color_white())
    draw_text_no_font_no_size("Alpha values for these shades", color_black(), 240, 40)

    # Draw each shade and use alpha_of to read its alpha component
    for i in range(3):
        value = alpha_of(shades[i])

        fill_rectangle(shades[i], 80 + i * 240, 140, 160, 80)
        draw_text_no_font_no_size(labels[i], color_black(), 115 + i * 240, 250)
        draw_text_no_font_no_size("Alpha: " + str(value), color_black(), 115 + i * 240, 290)

    refresh_screen_with_target_fps(60)

close_all_windows()
