using SplashKitSDK;

namespace AlphaOfExample
{
    public class Program
    {
        public static void Main()
        {
            // Open the window for the usage example
            SplashKit.OpenWindow("Reading the Alpha Channel", 800, 400);

            Color[] shades =
            {
                SplashKit.RGBAColor(180, 30, 80, 64),
                SplashKit.RGBAColor(180, 30, 80, 160),
                SplashKit.RGBAColor(180, 30, 80, 255)
            };

            string[] labels = { "Low Alpha", "Medium Alpha", "Full Alpha" };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Draw the background and instructions
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Alpha values for these shades", Color.Black, 240, 40);

                // Draw each shade and use alpha_of to read its alpha component
                for (int i = 0; i < 3; i++)
                {
                    int value = SplashKit.AlphaOf(shades[i]);

                    SplashKit.FillRectangle(shades[i], 80 + i * 240, 140, 160, 80);
                    SplashKit.DrawText(labels[i], Color.Black, 115 + i * 240, 250);
                    SplashKit.DrawText("Alpha: " + value.ToString(), Color.Black, 115 + i * 240, 290);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
