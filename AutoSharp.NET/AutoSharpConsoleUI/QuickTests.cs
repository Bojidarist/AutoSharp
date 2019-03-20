using AutoSharpLibrary;

namespace AutoSharpConsoleUI
{
    class QuickTests
    {
        public static void KeyboardInputTest()
        {
            string input = "2*5*5{Divide}5*5*5{Enter}";
            AutoSharpKeyboardInput.SendKeyboardInputToWindow(input, "Calculator", 1000);
        }

        public static void MouseInputTest(int x, int y, int delay)
        {
            //AutoSharpMouseInput.LeftMouseButtonClick(250, 360, 200, 5);
            //AutoSharpMouseInput.LeftMouseButtonDown(250, 360, 1000);

            AutoSharpMouseInput.MouseWheelScroll(x, y, delay);
        }
    }
}
