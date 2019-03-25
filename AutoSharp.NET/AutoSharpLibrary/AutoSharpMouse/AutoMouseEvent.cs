using System;
using System.Runtime.InteropServices;

namespace AutoSharpLibrary.AutoSharpMouse
{
    public class AutoMouseEvent
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        /// <summary>
        /// Synthesizes mouse motion and button clicks.
        /// </summary>
        /// <param name="mouseKeyFlag">Mouse key flag.</param>
        /// <param name="dx">The mouse's absolute position along the x-axis or its amount of motion since the last mouse event was generated.</param>
        /// <param name="dy">The mouse's absolute position along the y-axis or its amount of motion since the last mouse event was generated.</param>
        /// <param name="dwData">If mouseKeyFlag is not MOUSEEVENTF_WHEEL, MOUSEEVENTF_XDOWN, or MOUSEEVENTF_XUP, then dwData should be zero.</param>
        /// <param name="dwExtraInfo">An additional value associated with the mouse event.</param>
        public static void MouseEvent(int mouseKeyFlag, int dx, int dy, int dwData, IntPtr dwExtraInfo)
        {
            mouse_event(mouseKeyFlag, dx, dy, dwData, dwExtraInfo);
        }
    }
}
