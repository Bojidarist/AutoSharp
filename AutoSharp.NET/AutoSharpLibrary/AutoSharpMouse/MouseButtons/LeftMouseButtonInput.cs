namespace AutoSharp.AutoSharpMouse
{
    class LeftMouseButtonInput
    {
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
            MouseInputChecks.CheckMouseClickInputCoordinates(
                MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, MouseKeyFlags.MOUSEEVENTF_LEFTUP, x, y,
                millisecondClickDelay, numberOfClicks);
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
            MouseInputChecks.CheckMouseInputCoordinates(MouseKeyFlags.MOUSEEVENTF_LEFTDOWN, x, y, millisecondClickDelay);
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
            MouseInputChecks.CheckMouseInputCoordinates(MouseKeyFlags.MOUSEEVENTF_LEFTUP, x, y, millisecondClickDelay);
        }
        #endregion
    }
}
