using AutoSharp.AutoSharpMouse;
using System;

namespace AutoSharp
{
    /// <summary>
    /// The class for automating your UI
    /// </summary>
    public static class AutoSharpUI
    {
        #region Keyboard

        /// <summary>
        /// Synthesizes a keystroke
        /// </summary>
        /// <param name="keyCode">A virtual-key code. The code must be a value in the range 1 to 254</param>
        /// <param name="bScan">A hardware scan code for the key</param>
        /// <param name="dwFlags">Controls various aspects of function operation</param>
        /// <param name="dwExtraInfo">An additional value associated with the key stroke</param>
        public static void KeyboardEvent(KeyboardKeyCodes keyCode, byte bScan = 0, KeyboardEventFlags dwFlags = KeyboardEventFlags.NONE, int dwExtraInfo = 0)
        {
            AutoSharpKeyboard.AutoSharpKeyboardInput.KeyboardEvent(keyCode, bScan, (int)dwFlags, dwExtraInfo);
        }

        /// <summary>
        /// Sends keyboard input
        /// </summary>
        /// <param name="keysToPress">Keys to press</param>
        /// <param name="millisecondDelay">Delay in milliseconds</param>
        public static void SendKeyboardInput(string keysToPress, int millisecondDelay = 0)
        {
            AutoSharpKeyboard.AutoSharpKeyboardInput.SendKeyboardInput(keysToPress, millisecondDelay);
        }

        /// <summary>
        /// Sends keyboard input to specific process.
        /// </summary>
        /// <param name="keysToPress">Keys to press.</param>
        /// <param name="processName">Process name.</param>
        /// <param name="millisecondDelay">Delay in milliseconds.</param>
        public static void SendKeyboardInputToWindow(string keysToPress, string processName, int millisecondDelay = 0)
        {
            AutoSharpKeyboard.AutoSharpKeyboardInput.SendKeyboardInputToWindow(keysToPress, processName, millisecondDelay);
        }
        #endregion

        #region Mouse Cursor
        /// <summary>
        /// Sets the cursor's current position
        /// </summary>
        /// <param name="x">X coordinate (0 is top left)</param>
        /// <param name="y">Y coordinate (0 is top left)</param>
        public static void SetMouseCursorPos(int x, int y)
        {
            CursorInput.SetCursorPos(x, y);
        }

        /// <summary>
        /// Sets the cursor's current position
        /// </summary>
        /// <param name="coordinates">The coordinates to set the cursor's position to</param>
        public static void SetMouseCursorPos(CursorCoordinates coordinates)
        {
            CursorInput.SetCursorPos(coordinates.X, coordinates.Y);
        }

        /// <summary>
        /// Gets the current mouse cursor's position
        /// </summary>
        /// <returns></returns>
        public static CursorCoordinates GetMouseCursorPos()
        {
            return CursorInput.GetCursorPos();
        }
        #endregion

        #region Mouse

        #region Mouse Event

        /// <summary>
        /// Synthesizes mouse motion and button clicks
        /// </summary>
        /// <param name="mouseKeyFlag">Mouse key flag</param>
        /// <param name="dx">The mouse's absolute position along the x-axis or its amount of motion since the last mouse event was generated</param>
        /// <param name="dy">The mouse's absolute position along the y-axis or its amount of motion since the last mouse event was generated</param>
        /// <param name="dwData">If mouseKeyFlag is not MOUSEEVENTF_WHEEL, MOUSEEVENTF_XDOWN, or MOUSEEVENTF_XUP, then dwData should be zero</param>
        /// <param name="dwExtraInfo">An additional value associated with the mouse event</param>
        public static void MouseEvent(MouseKeyFlags mouseKeyFlag, int dx = 0, int dy = 0, int dwData = 0, int dwExtraInfo = 0)
        {
            AutoMouseEvent.MouseEvent(mouseKeyFlag, dx, dy, dwData, dwExtraInfo);
        }

        /// <summary>
        /// Synthesizes mouse motion and button clicks
        /// </summary>
        /// <param name="mouseKeyFlag">Mouse key flag</param>
        /// <param name="dx">The mouse's absolute position along the x-axis or its amount of motion since the last mouse event was generated</param>
        /// <param name="dy">The mouse's absolute position along the y-axis or its amount of motion since the last mouse event was generated</param>
        /// <param name="dwData">If mouseKeyFlag is not MOUSEEVENTF_WHEEL, MOUSEEVENTF_XDOWN, or MOUSEEVENTF_XUP, then dwData should be zero</param>
        /// <param name="dwExtraInfo">An additional value associated with the mouse event</param>
        public static void MouseEvent(int mouseKeyFlag, int dx, int dy, int dwData, IntPtr dwExtraInfo)
        {
            AutoMouseEvent.MouseEvent(mouseKeyFlag, dx, dy, dwData, dwExtraInfo);
        }

        #endregion

        #region Left Button
        /// <summary>
        /// Simulates left mouse button click
        /// </summary>
        /// <param name="x">
        /// X cursor position (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        /// <param name="numberOfClicks">Number of clicks</param>
        public static void LeftMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            LeftMouseButtonInput.LeftMouseButtonClick(x, y, millisecondClickDelay, numberOfClicks);
        }

        /// <summary>
        /// Simulates Left Mouse Button Down event
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        public static void LeftMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            LeftMouseButtonInput.LeftMouseButtonDown(x, y, millisecondClickDelay);
        }

        /// <summary>
        /// Simulates Left Mouse Button Up event
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        public static void LeftMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            LeftMouseButtonInput.LeftMouseButtonUp(x, y, millisecondClickDelay);
        }
        #endregion

        #region Right Button

        /// <summary>
        /// Simulates right mouse button click
        /// </summary>
        /// <param name="x">
        /// X cursor position (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        /// <param name="numberOfClicks">Number of clicks</param>
        public static void RightMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            RightMouseButtonInput.RightMouseButtonClick(x, y, millisecondClickDelay, numberOfClicks);
        }

        /// <summary>
        /// Simulates Right Mouse Button Down event
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        public static void RightMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            RightMouseButtonInput.RightMouseButtonDown(x, y, millisecondClickDelay);
        }

        /// <summary>
        /// Simulates Right Mouse Button Up event
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        public static void RightMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            RightMouseButtonInput.RightMouseButtonUp(x, y, millisecondClickDelay);
        }
        #endregion

        #region Middle Button

        /// <summary>
        /// Simulates middle mouse button click
        /// </summary>
        /// <param name="x">
        /// X cursor position (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        /// <param name="numberOfClicks">Number of clicks</param>
        public static void MiddleMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            MiddleMouseButtonInput.MiddleMouseButtonClick(x, y, millisecondClickDelay, numberOfClicks);
        }

        /// <summary>
        /// Simulates Middle Mouse Button Down event
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        public static void MiddleMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            MiddleMouseButtonInput.MiddleMouseButtonDown(x, y, millisecondClickDelay);
        }

        /// <summary>
        /// Simulates Middle Mouse Button Up event
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks</param>
        public static void MiddleMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            MiddleMouseButtonInput.MiddleMouseButtonUp(x, y, millisecondClickDelay);
        }
        #endregion

        #region Mouse Wheel

        /// <summary>
        /// Simulates mouse wheel scroll
        /// </summary>
        /// <param name="amount">Scroll amount (from -120 to 120 - positive is up | negative is down)</param>
        /// <param name="numberOfScrolls">Number of scrolls</param>
        /// <param name="millisecondDelay">Delay between scrolls</param>
        public static void MouseWheelScroll(int amount, int numberOfScrolls = 1, int millisecondDelay = 0)
        {
            MouseWheelInput.MouseWheelScroll(amount, numberOfScrolls, millisecondDelay);
        }
        #endregion

        #endregion
    }
}
