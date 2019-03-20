using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoSharpLibrary
{
    public class AutoSharpMouseInput
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        [DllImport("User32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        // Left Button
        public static void LeftMouseButtonClick(int x, int y, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            SetCursorPos(x, y);

            for (int i = 0; i < numberOfClicks; i++)
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, x, y, 0, IntPtr.Zero);
                mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTUP, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }

        public static void LeftMouseButtonDown(int x, int y, int millisecondClickDelay = 0)
        {
            SetCursorPos(x, y);

            mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, x, y, 0, IntPtr.Zero);
            Thread.Sleep(millisecondClickDelay);
        }

        public static void LeftMouseButtonUp(int x, int y, int millisecondClickDelay = 0)
        {
            SetCursorPos(x, y);

            mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTUP, x, y, 0, IntPtr.Zero);
            Thread.Sleep(millisecondClickDelay);
        }

        // Right Button
        public static void RightMouseButtonClick(int x, int y, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            SetCursorPos(x, y);

            for (int i = 0; i < numberOfClicks; i++)
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, x, y, 0, IntPtr.Zero);
                mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }

        public static void RightMouseButtonDown(int x, int y, int millisecondClickDelay = 0)
        {
            SetCursorPos(x, y);

            mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, x, y, 0, IntPtr.Zero);
            Thread.Sleep(millisecondClickDelay);
        }

        public static void RightMouseButtonUp(int x, int y, int millisecondClickDelay = 0)
        {
            SetCursorPos(x, y);

            mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, x, y, 0, IntPtr.Zero);
            Thread.Sleep(millisecondClickDelay);
        }

        // Middle Button
        public static void MiddleMouseButtonClick(int x, int y, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            SetCursorPos(x, y);

            for (int i = 0; i < numberOfClicks; i++)
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, x, y, 0, IntPtr.Zero);
                mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }

        public static void MiddleMouseButtonDown(int x, int y, int millisecondClickDelay = 0)
        {
            SetCursorPos(x, y);

            mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, x, y, 0, IntPtr.Zero);
            Thread.Sleep(millisecondClickDelay);
        }

        public static void MiddleMouseButtonUp(int x, int y, int millisecondClickDelay = 0)
        {
            SetCursorPos(x, y);

            mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, x, y, 0, IntPtr.Zero);
            Thread.Sleep(millisecondClickDelay);
        }

        // Mouse Wheel
        public static void MouseWheelScroll(int amount, int numberOfScrolls = 1, int millisecondDelay = 0)
        {
            for (int i = 0; i < numberOfScrolls; i++)
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_WHEEL, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, amount, IntPtr.Zero);

                Thread.Sleep(millisecondDelay);
            }
        }
    }
}
