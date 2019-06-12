using System.Threading;

namespace AutoSharp.AutoSharpMouse
{
    class MouseWheelInput
    {
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
                AutoMouseEvent.MouseEvent(MouseKeyFlags.MOUSEEVENTF_WHEEL, dwData:amount);

                Thread.Sleep(millisecondDelay);
            }
        }
        #endregion
    }
}
