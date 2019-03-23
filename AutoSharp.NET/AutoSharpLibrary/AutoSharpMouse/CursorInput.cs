using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoSharpLibrary.AutoSharpMouse
{
    public class CursorInput
    {
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
    }
}
