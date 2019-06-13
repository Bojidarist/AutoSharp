namespace AutoSharp
{
    /// <summary>
    /// Flags for KeyboardEvent
    /// </summary>
    public enum KeyboardEventFlags : int
    {
        /// <summary>
        /// No flags
        /// </summary>
        NONE = 0,

        /// <summary>
        /// Similar to KeyDown flag
        /// </summary>
        KEYEVENTF_EXTENDEDKEY = 0x0001,

        /// <summary>
        /// KeyUp flag
        /// </summary>
        KEYEVENTF_KEYUP = 0x0002,

        /// <summary>
        /// If specified, the system synthesizes a VK_PACKET keystroke
        /// The wVk parameter must be zero
        /// This flag can only be combined with the KEYEVENTF_KEYUP flag
        /// </summary>
        KEYEVENTF_UNICODE = 0x0004,

        /// <summary>
        /// If specified, wScan identifies the key and wVk is ignored
        /// </summary>
        KEYEVENTF_SCANCODE = 0x0008
    }
}
