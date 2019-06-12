using AutoSharp.AutoSharpMouse;
using System;

namespace AutoSharp
{
    public class AutoSharpUI
    {
        #region Keyboard
        public static void KeyboardEvent(KeyboardKeyCodes keyCode, byte bScan = 0, int dwFlags = 0, int dwExtraInfo = 0)
        {
            AutoSharpKeyboard.AutoSharpKeyboardInput.KeyboardEvent(keyCode, bScan, dwFlags, dwExtraInfo);
        }

        public static void SendKeyboardInput(string keysToPress, int millisecondDelay = 0)
        {
            AutoSharpKeyboard.AutoSharpKeyboardInput.SendKeyboardInput(keysToPress, millisecondDelay);
        }

        public static void SendKeyboardInputToWindow(string keysToPress, string processName, int millisecondDelay = 0)
        {
            AutoSharpKeyboard.AutoSharpKeyboardInput.SendKeyboardInputToWindow(keysToPress, processName, millisecondDelay);
        }
        #endregion

        #region Mouse Cursor
        public static void SetMouseCursorPos(int x, int y)
        {
            CursorInput.SetCursorPos(x, y);
        }

        public static void SetMouseCursorPos(CursorCoordinates coordinates)
        {
            CursorInput.SetCursorPos(coordinates.X, coordinates.Y);
        }

        public static CursorCoordinates GetMouseCursorPos()
        {
            return CursorInput.GetCursorPos();
        }
        #endregion

        #region Mouse
        public static void MouseEvent(MouseKeyFlags mouseKeyFlag, int dx = 0, int dy = 0, int dwData = 0, int dwExtraInfo = 0)
        {
            AutoMouseEvent.MouseEvent(mouseKeyFlag, dx, dy, dwData, dwExtraInfo);
        }

        public static void MouseEvent(int mouseKeyFlag, int dx, int dy, int dwData, IntPtr dwExtraInfo)
        {
            AutoMouseEvent.MouseEvent(mouseKeyFlag, dx, dy, dwData, dwExtraInfo);
        }

        #region Left Button
        public static void LeftMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            LeftMouseButtonInput.LeftMouseButtonClick(x, y, millisecondClickDelay, numberOfClicks);
        }

        public static void LeftMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            LeftMouseButtonInput.LeftMouseButtonDown(x, y, millisecondClickDelay);
        }

        public static void LeftMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            LeftMouseButtonInput.LeftMouseButtonUp(x, y, millisecondClickDelay);
        }
        #endregion

        #region Right Button
        public static void RightMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            RightMouseButtonInput.RightMouseButtonClick(x, y, millisecondClickDelay, numberOfClicks);
        }

        public static void RightMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            RightMouseButtonInput.RightMouseButtonDown(x, y, millisecondClickDelay);
        }

        public static void RightMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            RightMouseButtonInput.RightMouseButtonUp(x, y, millisecondClickDelay);
        }
        #endregion

        #region Middle Button
        public static void MiddleMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            MiddleMouseButtonInput.MiddleMouseButtonClick(x, y, millisecondClickDelay, numberOfClicks);
        }

        public static void MiddleMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            MiddleMouseButtonInput.MiddleMouseButtonDown(x, y, millisecondClickDelay);
        }

        public static void MiddleMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            MiddleMouseButtonInput.MiddleMouseButtonUp(x, y, millisecondClickDelay);
        }
        #endregion

        #region Mouse Wheel
        public static void MouseWheelScroll(int amount, int numberOfScrolls = 1, int millisecondDelay = 0)
        {
            MouseWheelInput.MouseWheelScroll(amount, numberOfScrolls, millisecondDelay);
        }
        #endregion

        #endregion
    }
}
