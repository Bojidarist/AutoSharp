using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoSharpLibrary.AutoSharpMouse
{
    public class MouseWheelInput
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

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
