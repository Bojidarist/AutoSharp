using System;
using System.Threading;

namespace AutoSharpLibrary.AutoSharpMouse
{
    class MouseInputChecks
    {
        public static void CheckMouseClickInputCoordinates(int buttonDownFlag, int buttonUpFlag, int x, int y, int millisecondClickDelay, int numberOfClicks = 1)
        {
            if (x != 0 && y != 0)
            {
                CursorInput.SetCursorPos(x, y);

                for (int i = 0; i < numberOfClicks; i++)
                {
                    AutoMouseEvent.MouseEvent(buttonDownFlag, x, y, 0, IntPtr.Zero);
                    AutoMouseEvent.MouseEvent(buttonUpFlag, x, y, 0, IntPtr.Zero);

                    Thread.Sleep(millisecondClickDelay);
                }
            }
            else
            {
                for (int i = 0; i < numberOfClicks; i++)
                {
                    AutoMouseEvent.MouseEvent(buttonDownFlag, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                    AutoMouseEvent.MouseEvent(buttonUpFlag, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
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

                AutoMouseEvent.MouseEvent(buttonFlag, x, y, 0, IntPtr.Zero);

                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                AutoMouseEvent.MouseEvent(buttonFlag, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                Thread.Sleep(millisecondClickDelay);
            }
        }
    }
}
