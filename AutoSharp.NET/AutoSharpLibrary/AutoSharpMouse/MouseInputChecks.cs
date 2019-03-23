using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoSharpLibrary.AutoSharpMouse
{
    class MouseInputChecks
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        public static void CheckMouseClickInputCoordinates(int buttonDownFlag, int buttonUpFlag, int x, int y, int millisecondClickDelay, int numberOfClicks = 1)
        {
            if (x != 0 && y != 0)
            {
                CursorInput.SetCursorPos(x, y);

                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(buttonDownFlag, x, y, 0, IntPtr.Zero);
                    mouse_event(buttonUpFlag, x, y, 0, IntPtr.Zero);

                    Thread.Sleep(millisecondClickDelay);
                }
            }
            else
            {
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(buttonDownFlag, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                    mouse_event(buttonUpFlag, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                    Thread.Sleep(millisecondClickDelay);
                }
            }
        }

        public static void CheckMouseInputCoordinates(int buttonFlag, int x, int y, int millisecondClickDelay)
        {
            if (x != 0 && y != 0)
            {
                CursorInput.SetCursorPos(x, y);

                mouse_event(buttonFlag, x, y, 0, IntPtr.Zero);

                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(buttonFlag, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                Thread.Sleep(millisecondClickDelay);
            }
        }
    }
}
