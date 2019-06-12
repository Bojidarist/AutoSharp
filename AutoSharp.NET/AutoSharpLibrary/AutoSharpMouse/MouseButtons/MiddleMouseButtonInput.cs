namespace AutoSharpLibrary.AutoSharpMouse
{
    class MiddleMouseButtonInput
    {
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
            MouseInputChecks.CheckMouseClickInputCoordinates(
                MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, MouseKeyFlags.MOUSEEVENTF_MIDDLEUP,
                x, y, millisecondClickDelay, numberOfClicks);
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
            MouseInputChecks.CheckMouseInputCoordinates(MouseKeyFlags.MOUSEEVENTF_MIDDLEDOWN, x, y, millisecondClickDelay);
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
            MouseInputChecks.CheckMouseInputCoordinates(MouseKeyFlags.MOUSEEVENTF_MIDDLEUP, x, y, millisecondClickDelay);
        }
        #endregion
    }
}
