using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open the window for the usage example
OpenWindow("Reading the Alpha Channel", 800, 400);

Color[] shades =
{
    RGBAColor(180, 30, 80, 64),
    RGBAColor(180, 30, 80, 160),
    RGBAColor(180, 30, 80, 255)
};

string[] labels = { "Low Alpha", "Medium Alpha", "Full Alpha" };

while (!QuitRequested())
{
    ProcessEvents();

    // Draw the background and instructions
    ClearScreen(Color.White);
    DrawText("Alpha values for these shades", Color.Black, 240, 40);

    // Draw each shade and use alpha_of to read its alpha component
    for (int i = 0; i < 3; i++)
    {
        int value = AlphaOf(shades[i]);

        FillRectangle(shades[i], 80 + i * 240, 140, 160, 80);
        DrawText(labels[i], Color.Black, 115 + i * 240, 250);
        DrawText("Alpha: " + value.ToString(), Color.Black, 115 + i * 240, 290);
    }

    RefreshScreen(60);
}

CloseAllWindows();
