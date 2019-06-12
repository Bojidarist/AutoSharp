using AutoSharp;

namespace AutoSharpConsoleUI
{
    class QuickTests
    {
        public static void KeyboardInputTest()
        {
            //string input = "2*5*5{Divide}5*5*5{Enter}";
            //AutoSharpKeyboardInput.SendKeyboardInputToWindow(input, "Calculator", 1000);
            AutoSharpUI.KeyboardEvent(KeyboardKeyCodes.VK_CAPITAL);
        }

        public static void MouseInputTest(int x = 0, int y = 0, int delay = 0)
        {
            //CursorInput.GetCursorPos();
            //LeftMouseButtonInput.LeftMouseButtonClick();
            //RightMouseButtonInput.RightMouseButtonClick();
            //MiddleMouseButtonInput.MiddleMouseButtonClick();
            //MouseWheelInput.MouseWheelScroll(120, 5, 500);
            //AutoMouseEvent.MouseEvent(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, System.IntPtr.Zero);            
        }
    }
}
