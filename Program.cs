using System;
using System.Drawing;
using System.Runtime.InteropServices;
using WindowsInput;
namespace SnapchatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                for(int y = 78; y < 700; y+=58){
                    Color pixelColor = GetColorAt(993, y);
                    //Color [A=255, R=243, G=70, B=95]
                    if(pixelColor.R > 238 && pixelColor.G > 60 && pixelColor.G < 80 && pixelColor.B > 85 && pixelColor.B < 105){
                        // Console.WriteLine(y);
                        // Console.WriteLine(pixelColor);
                        //483 425 368 310
                        //   58  57  58
                        float xMultiplier = 993f / 1366f;
                        float yMultiplier = y / 768f;
                        new InputSimulator().Keyboard
                            .Mouse
                            .MoveMouseToPositionOnVirtualDesktop(xMultiplier * 65535, yMultiplier * 65535)
                            .LeftButtonClick()
                            .Sleep(1000)
                            .LeftButtonClick()
                            .Sleep(2000);
                    }
                }

                for(int i = 0; i < 9; i++){
                // 142 199 256 314 373 429 488 545 604
                int y = 0;
                if(i == 0){
                    y = 136;
                }else if(i == 1){
                    y = 193;
                }else if(i == 2){
                    y = 261;
                }else if(i == 3){
                    y = 319;
                }else if(i == 4){
                    y = 378;
                }else if(i == 5){
                    y = 434;
                }else if(i == 6){
                    y = 493;
                }else if(i == 7){
                    y = 550;
                }else if(i == 8){
                    y = 609;
                }

                Color pixelColor = GetColorAt(1295, y);
                //Console.WriteLine(pixelColor);
                float xMultiplier5 = 1295f / 1366f;
                float yMultiplier5 = y / 768f;
                new InputSimulator().Keyboard
                    .Mouse
                    .MoveMouseToPositionOnVirtualDesktop(xMultiplier5 * 65535, yMultiplier5 * 65535)
                    .Sleep(1000);

                //Color [A=255, R=243, G=70, B=95]
                if(pixelColor.R < 80 && pixelColor.G < 80 && pixelColor.B < 80){
                    // Console.WriteLine(y);
                    // Console.WriteLine(pixelColor);
                    //483 425 368 310
                    //   58  57  58
                    float xMultiplier1 = 1295f / 1366f;
                    float yMultiplier1 = y / 768f;
                    float xMultiplier2 = 1130f / 1366f;
                    float yMultiplier2 = 670f / 768f;
                    float xMultiplier3 = 1303f / 1366f;
                    float yMultiplier3 = 86f / 768f;
                    float xMultiplier4 = 1280f / 1366f;
                    float yMultiplier4 = 735f / 768f;
                    new InputSimulator().Keyboard
                        .Mouse
                        .MoveMouseToPositionOnVirtualDesktop(xMultiplier1 * 65535, yMultiplier1 * 65535)
                        .LeftButtonClick()
                        .Sleep(4000)
                        .MoveMouseToPositionOnVirtualDesktop(xMultiplier2 * 65535, yMultiplier2 * 65535)
                        .LeftButtonClick()
                        .Sleep(2000)
                        .MoveMouseToPositionOnVirtualDesktop(xMultiplier3 * 65535, yMultiplier3 * 65535)
                        .LeftButtonClick()
                        .Sleep(2000)
                        .Keyboard
                        .ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V)
                        .Sleep(2000)
                        .Mouse
                        .MoveMouseToPositionOnVirtualDesktop(xMultiplier3 * 65535, yMultiplier3 * 65535)
                        .LeftButtonClick()
                        .Sleep(2000)
                        .MoveMouseToPositionOnVirtualDesktop(xMultiplier4 * 65535, yMultiplier4 * 65535)
                        .LeftButtonClick()
                        .Sleep(2000);
                }
                }
            }
            // new InputSimulator().Keyboard
            //     // .ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            //     .Mouse
            //     .MoveMouseToPositionOnVirtualDesktop(47600, 16500);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int) GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }
    }
}


// this was sent by my automated snap program since i don't feel like using the app
// view the painful code behind it at github.com/decentishdev/snapchatbot


