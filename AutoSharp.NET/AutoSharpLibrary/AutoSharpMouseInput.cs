using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoSharpLibrary
{
    public class AutoSharpMouseInput
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        #region Cursor
        /// <summary>
        /// Sets the cursors's current position.
        /// </summary>
        /// <param name="x">X coordinate (0 is top left).</param>
        /// <param name="y">Y coordinate (0 is top left).</param>
        [DllImport("User32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        /// <summary>
        /// Gets the current cursor position. (Using System.Drawing)
        /// </summary>
        public static Point GetCursorPos() { return Cursor.Position; }
        #endregion

        #region LeftMouseButton
        // Left Button
        /// <summary>
        /// Simulates left mouse button click.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        /// <param name="numberOfClicks">Number of clicks.</param>
        public static void LeftMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, x, y, 0, IntPtr.Zero);
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTUP, x, y, 0, IntPtr.Zero);
                    Thread.Sleep(millisecondClickDelay);
                }
            }
            else
            {
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                    mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTUP, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                    Thread.Sleep(millisecondClickDelay);
                }
            }
        }

        /// <summary>
        /// Simulates Left Mouse Button Down event.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        public static void LeftMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);

                mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }

        /// <summary>
        /// Simulates Left Mouse Button Up event.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        public static void LeftMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);

                mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTUP, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_LEFTUP, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }
        #endregion

        #region RightMouseButton
        // Right Button
        /// <summary>
        /// Simulates right mouse button click.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        /// <param name="numberOfClicks">Number of clicks.</param>
        public static void RightMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, x, y, 0, IntPtr.Zero);
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, x, y, 0, IntPtr.Zero);
                    Thread.Sleep(millisecondClickDelay);
                }
            }
            else
            {
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                    mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                    Thread.Sleep(millisecondClickDelay);
                }
            }
        }

        /// <summary>
        /// Simulates Right Mouse Button Down event.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        public static void RightMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);

                mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }

        /// <summary>
        /// Simulates Right Mouse Button Up event.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        public static void RightMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);

                mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }
        #endregion

        #region MiddleMouseButton
        // Middle Button
        /// <summary>
        /// Simulates middle mouse button click.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        /// <param name="numberOfClicks">Number of clicks.</param>
        public static void MiddleMouseButtonClick(int x = 0, int y = 0, int millisecondClickDelay = 0, int numberOfClicks = 1)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, x, y, 0, IntPtr.Zero);
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, x, y, 0, IntPtr.Zero);
                    Thread.Sleep(millisecondClickDelay);
                }
            }
            else
            {
                for (int i = 0; i < numberOfClicks; i++)
                {
                    mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);

                    mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                        MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                    Thread.Sleep(millisecondClickDelay);
                }
            }
        }

        /// <summary>
        /// Simulates Middle Mouse Button Down event.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        public static void MiddleMouseButtonDown(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);

                mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }

        /// <summary>
        /// Simulates Middle Mouse Button Up event.
        /// </summary>
        /// <param name="x">
        /// X cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="y">
        /// Y cursor position. (If X = 0 or Y = 0 the click will be at current coordinates.)
        /// </param>
        /// <param name="millisecondClickDelay">Delay between clicks.</param>
        public static void MiddleMouseButtonUp(int x = 0, int y = 0, int millisecondClickDelay = 0)
        {
            if (x != 0 && y != 0)
            {
                SetCursorPos(x, y);

                mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, x, y, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, 0, IntPtr.Zero);
                Thread.Sleep(millisecondClickDelay);
            }
        }
        #endregion

        #region MouseWheel
        // Mouse Wheel
        /// <summary>
        /// Simulates mouse wheel scroll.
        /// </summary>
        /// <param name="amount">Scroll amount (from -120 to 120 - positive is up | negative is down).</param>
        /// <param name="numberOfScrolls">Number of scrolls.</param>
        /// <param name="millisecondDelay">Delay between scrolls.</param>
        public static void MouseWheelScroll(int amount, int numberOfScrolls = 1, int millisecondDelay = 0)
        {
            for (int i = 0; i < numberOfScrolls; i++)
            {
                mouse_event(MouseKeyFlags.MOUSEEVENTF_WHEEL, MouseKeyFlags.MOUSEEVENTF_ABSOLUTE,
                    MouseKeyFlags.MOUSEEVENTF_ABSOLUTE, amount, IntPtr.Zero);

                Thread.Sleep(millisecondDelay);
            }
        }
        #endregion
    }
}
