using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoSharpLibrary.AutoSharpKeyboard
{
    class WindowManagement
    {
        #region SetForegroundWindow
        public static void SetForegroundWindow(string processName)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                if (IsProcessCorrect(proc, processName))
                {
                    ActivateWindow(proc.MainWindowHandle);
                }
            }
        }

        private static bool IsProcessCorrect(Process proc, string processName)
        {
            return proc.MainWindowTitle.EndsWith(processName, StringComparison.InvariantCultureIgnoreCase);
        }
        #endregion

        #region ActivateWindow
        private const int EXTENDEDKEY = 0x1;
        private const int KEYUP = 0x2;
        private const int ALT = 0xA4;
        private const int SHOW_NORMAL = 5;
        private const int SHOW_MINIMIZED = 4;
        private const int SHOW_MAXIMIZED = 3;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private static void ActivateWindow(IntPtr mainWindowHandle)
        {
            // Guard: check if window already has focus.
            if (mainWindowHandle == GetForegroundWindow())
            {
                return;
            }

            // Show window.
            ShowWindow(mainWindowHandle, SHOW_NORMAL);

            // Simulate an "ALT" key press.
            keybd_event((byte)ALT, 0x45, EXTENDEDKEY | 0, 0);

            // Simulate an "ALT" key release.
            keybd_event((byte)ALT, 0x45, EXTENDEDKEY | KEYUP, 0);

            // Show window in forground.
            SetForegroundWindow(mainWindowHandle);
        }
        #endregion
    }
}

