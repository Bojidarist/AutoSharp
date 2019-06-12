namespace AutoSharpLibrary.AutoSharpMouse
{
    class RightMouseButtonInput
    {
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
            MouseInputChecks.CheckMouseClickInputCoordinates(
                MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, MouseKeyFlags.MOUSEEVENTF_RIGHTUP,
                x, y, millisecondClickDelay, numberOfClicks);
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
            MouseInputChecks.CheckMouseInputCoordinates(MouseKeyFlags.MOUSEEVENTF_RIGHTDOWN, x, y, millisecondClickDelay);
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
            MouseInputChecks.CheckMouseInputCoordinates(MouseKeyFlags.MOUSEEVENTF_RIGHTUP, x, y, millisecondClickDelay);
        }
        #endregion
    }
}
