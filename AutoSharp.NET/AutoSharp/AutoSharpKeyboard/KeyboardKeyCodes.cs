namespace AutoSharp
{
    public enum KeyboardKeyCodes : byte
    {
        #region Mappable codes
        /// <summary>
        /// Abnt C1
        /// </summary>
        VK_ABNT_C1 = 0xC1,

        /// <summary>
        /// Abnt C2
        /// </summary>
        VK_ABNT_C2 = 0xC2,

        /// <summary>
        /// Numpad +
        /// </summary>
        VK_ADD = 0x6B,

        /// <summary>
        /// Attn
        /// </summary>
        VK_ATTN = 0xF6,

        /// <summary>
        /// Backspace
        /// </summary>
        VK_BACK = 0x08,

        /// <summary>
        /// Break
        /// </summary>
        VK_CANCEL = 0x03,

        /// <summary>
        /// Clear
        /// </summary>
        VK_CLEAR = 0x0C,

        /// <summary>
        /// Cr Sel
        /// </summary>
        VK_CRSEL = 0xF7,

        /// <summary>
        /// Numpad .
        /// </summary>
        VK_DECIMAL = 0x6E,

        /// <summary>
        /// Numpad /
        /// </summary>
        VK_DIVIDE = 0x6F,

        /// <summary>
        /// Er Eof
        /// </summary>
        VK_EREOF = 0xF9,

        /// <summary>
        /// Esc
        /// </summary>
        VK_ESCAPE = 0x1B,

        /// <summary>
        /// Execute
        /// </summary>
        VK_EXECUTE = 0x2B,

        /// <summary>
        /// Ex Sel
        /// </summary>
        VK_EXSEL = 0xF8,

        /// <summary>
        /// IcoClr
        /// </summary>
        VK_ICO_CLEAR = 0xE6,

        /// <summary>
        /// IcoHlp
        /// </summary>
        VK_ICO_HELP = 0xE3,

        /// <summary>
        /// 0
        /// </summary>
        VK_KEY_0 = 0x30,

        /// <summary>
        /// 1
        /// </summary>
        VK_KEY_1 = 0x31,

        /// <summary>
        /// 2
        /// </summary>
        VK_KEY_2 = 0x32,

        /// <summary>
        /// 3
        /// </summary>
        VK_KEY_3 = 0x33,

        /// <summary>
        /// 4
        /// </summary>
        VK_KEY_4 = 0x34,

        /// <summary>
        /// 5
        /// </summary>
        VK_KEY_5 = 0x35,

        /// <summary>
        /// 6
        /// </summary>
        VK_KEY_6 = 0x36,

        /// <summary>
        /// 7
        /// </summary>
        VK_KEY_7 = 0x37,

        /// <summary>
        /// 8
        /// </summary>
        VK_KEY_8 = 0x38,

        /// <summary>
        /// 9
        /// </summary>
        VK_KEY_9 = 0x39,

        /// <summary>
        /// A
        /// </summary>
        VK_KEY_A = 0x41,

        /// <summary>
        /// B
        /// </summary>
        VK_KEY_B = 0x42,

        /// <summary>
        /// C
        /// </summary>
        VK_KEY_C = 0x43,

        /// <summary>
        /// D
        /// </summary>
        VK_KEY_D = 0x44,

        /// <summary>
        /// E
        /// </summary>
        VK_KEY_E = 0x45,

        /// <summary>
        /// F
        /// </summary>
        VK_KEY_F = 0x46,

        /// <summary>
        /// G
        /// </summary>
        VK_KEY_G = 0x47,

        /// <summary>
        /// H
        /// </summary>
        VK_KEY_H = 0x48,

        /// <summary>
        /// I
        /// </summary>
        VK_KEY_I = 0x49,

        /// <summary>
        /// J
        /// </summary>
        VK_KEY_J = 0x4A,

        /// <summary>
        /// K
        /// </summary>
        VK_KEY_K = 0x4B,

        /// <summary>
        /// L
        /// </summary>
        VK_KEY_L = 0x4C,

        /// <summary>
        /// M
        /// </summary>
        VK_KEY_M = 0x4D,

        /// <summary>
        /// N
        /// </summary>
        VK_KEY_N = 0x4E,

        /// <summary>
        /// O
        /// </summary>
        VK_KEY_O = 0x4F,

        /// <summary>
        /// P
        /// </summary>
        VK_KEY_P = 0x50,

        /// <summary>
        /// Q
        /// </summary>
        VK_KEY_Q = 0x51,

        /// <summary>
        /// R
        /// </summary>
        VK_KEY_R = 0x52,

        /// <summary>
        /// S
        /// </summary>
        VK_KEY_S = 0x53,

        /// <summary>
        /// T
        /// </summary>
        VK_KEY_T = 0x54,

        /// <summary>
        /// U
        /// </summary>
        VK_KEY_U = 0x55,

        /// <summary>
        /// V
        /// </summary>
        VK_KEY_V = 0x56,

        /// <summary>
        /// W
        /// </summary>
        VK_KEY_W = 0x57,

        /// <summary>
        /// X
        /// </summary>
        VK_KEY_X = 0x58,

        /// <summary>
        /// Y
        /// </summary>
        VK_KEY_Y = 0x59,

        /// <summary>
        /// Z
        /// </summary>
        VK_KEY_Z = 0x5A,

        /// <summary>
        /// Numpad *
        /// </summary>
        VK_MULTIPLY = 0x6A,

        /// <summary>
        /// NoName
        /// </summary>
        VK_NONAME = 0xFC,

        /// <summary>
        /// Numpad 0
        /// </summary>
        VK_NUMPAD0 = 0x60,

        /// <summary>
        /// Numpad 1
        /// </summary>
        VK_NUMPAD1 = 0x61,

        /// <summary>
        /// Numpad 2
        /// </summary>
        VK_NUMPAD2 = 0x62,

        /// <summary>
        /// Numpad 3
        /// </summary>
        VK_NUMPAD3 = 0x63,

        /// <summary>
        /// Numpad 4
        /// </summary>
        VK_NUMPAD4 = 0x64,

        /// <summary>
        /// Numpad 5
        /// </summary>
        VK_NUMPAD5 = 0x65,

        /// <summary>
        /// Numpad 6
        /// </summary>
        VK_NUMPAD6 = 0x66,

        /// <summary>
        /// Numpad 7
        /// </summary>
        VK_NUMPAD7 = 0x67,

        /// <summary>
        /// Numpad 8
        /// </summary>
        VK_NUMPAD8 = 0x68,

        /// <summary>
        /// Numpad 9
        /// </summary>
        VK_NUMPAD9 = 0x69,

        /// <summary>
        /// OEM_1 (: ;)
        /// </summary>
        VK_OEM_1 = 0xBA,

        /// <summary>
        /// OEM_102 (> <)
        /// </summary>
        VK_OEM_102 = 0xE2,

        /// <summary>
        /// OEM_2 (? /)
        /// </summary>
        VK_OEM_2 = 0xBF,

        /// <summary>
        /// OEM_3 (~ `)
        /// </summary>
        VK_OEM_3 = 0xC0,

        /// <summary>
        /// OEM_4 ({ [)
        /// </summary>
        VK_OEM_4 = 0xDB,

        /// <summary>
        /// OEM_5 (| \)
        /// </summary>
        VK_OEM_5 = 0xDC,

        /// <summary>
        /// OEM_6 (} ])
        /// </summary>
        VK_OEM_6 = 0xDD,

        /// <summary>
        /// OEM_7 (" ')
        /// </summary>
        VK_OEM_7 = 0xDE,

        /// <summary>
        /// OEM_8 (§ !)
        /// </summary>
        VK_OEM_8 = 0xDF,

        /// <summary>
        /// Oem Attn
        /// </summary>
        VK_OEM_ATTN = 0xF0,

        /// <summary>
        /// Auto
        /// </summary>
        VK_OEM_AUTO = 0xF3,

        /// <summary>
        /// Ax
        /// </summary>
        VK_OEM_AX = 0xE1,

        /// <summary>
        /// Back Tab
        /// </summary>
        VK_OEM_BACKTAB = 0xF5,

        /// <summary>
        /// OemClr
        /// </summary>
        VK_OEM_CLEAR = 0xFE,

        /// <summary>
        /// OEM_COMMA (< ,)
        /// </summary>
        VK_OEM_COMMA = 0xBC,

        /// <summary>
        /// Copy
        /// </summary>
        VK_OEM_COPY = 0xF2,

        /// <summary>
        /// Cu Sel
        /// </summary>
        VK_OEM_CUSEL = 0xEF,

        /// <summary>
        /// Enlw
        /// </summary>
        VK_OEM_ENLW = 0xF4,

        /// <summary>
        /// Finish
        /// </summary>
        VK_OEM_FINISH = 0xF1,

        /// <summary>
        /// Loya
        /// </summary>
        VK_OEM_FJ_LOYA = 0x95,

        /// <summary>
        /// Mashu
        /// </summary>
        VK_OEM_FJ_MASSHOU = 0x93,

        /// <summary>
        /// Roya
        /// </summary>
        VK_OEM_FJ_ROYA = 0x96,

        /// <summary>
        /// Touroku
        /// </summary>
        VK_OEM_FJ_TOUROKU = 0x94,

        /// <summary>
        /// Jump
        /// </summary>
        VK_OEM_JUMP = 0xEA,

        /// <summary>
        /// OEM_MINUS (_ -)
        /// </summary>
        VK_OEM_MINUS = 0xBD,

        /// <summary>
        /// OemPa1
        /// </summary>
        VK_OEM_PA1 = 0xEB,

        /// <summary>
        /// OemPa2
        /// </summary>
        VK_OEM_PA2 = 0xEC,

        /// <summary>
        /// OemPa3
        /// </summary>
        VK_OEM_PA3 = 0xED,

        /// <summary>
        /// OEM_PERIOD (> .)
        /// </summary>
        VK_OEM_PERIOD = 0xBE,

        /// <summary>
        /// OEM_PLUS (+ =)
        /// </summary>
        VK_OEM_PLUS = 0xBB,

        /// <summary>
        /// Reset
        /// </summary>
        VK_OEM_RESET = 0xE9,

        /// <summary>
        /// WsCtrl
        /// </summary>
        VK_OEM_WSCTRL = 0xEE,

        /// <summary>
        /// Pa1
        /// </summary>
        VK_PA1 = 0xFD,

        /// <summary>
        /// Packet
        /// </summary>
        VK_PACKET = 0xE7,

        /// <summary>
        /// Play
        /// </summary>
        VK_PLAY = 0xFA,

        /// <summary>
        /// Process
        /// </summary>
        VK_PROCESSKEY = 0xE5,

        /// <summary>
        /// Enter
        /// </summary>
        VK_RETURN = 0x0D,

        /// <summary>
        /// Select
        /// </summary>
        VK_SELECT = 0x29,

        /// <summary>
        /// Seperator
        /// </summary>
        VK_SEPERATOR = 0x6C,

        /// <summary>
        /// Space
        /// </summary>
        VK_SPACE = 0x20,

        /// <summary>
        /// Num -
        /// </summary>
        VK_SUBTRACT = 0x6D,

        /// <summary>
        /// Tab
        /// </summary>
        VK_TAB = 0x09,

        /// <summary>
        /// Zoom
        /// </summary>
        VK_ZOOM = 0xFB,
        #endregion

        #region Non-mappable codes
        /// <summary>
        /// no VK mapping
        /// </summary>
        VK__none_ = 0xFF,

        /// <summary>
        /// Accept
        /// </summary>
        VK_ACCEPT = 0x1E,

        /// <summary>
        /// Context Menu
        /// </summary>
        VK_APPS = 0x5D,

        /// <summary>
        /// Browser Back
        /// </summary>
        VK_BROWSER_BACK = 0xA6,

        /// <summary>
        /// Browser Favorites
        /// </summary>
        VK_BROWSER_FAVORITES = 0xAB,

        /// <summary>
        /// Browser Forward
        /// </summary>
        VK_BROWSER_FORWARD = 0xA7,

        /// <summary>
        /// Browser Home
        /// </summary>
        VK_BROWSER_HOME = 0xAC,

        /// <summary>
        /// Browser Refresh
        /// </summary>
        VK_BROWSER_REFRESH = 0xA8,

        /// <summary>
        /// Browser Search
        /// </summary>
        VK_BROWSER_SEARCH = 0xAA,

        /// <summary>
        /// Browser Stop
        /// </summary>
        VK_BROWSER_STOP = 0xA9,

        /// <summary>
        /// Caps Lock
        /// </summary>
        VK_CAPITAL = 0x14,

        /// <summary>
        /// Convert
        /// </summary>
        VK_CONVERT = 0x1C,

        /// <summary>
        /// Delete
        /// </summary>
        VK_DELETE = 0x2E,

        /// <summary>
        /// Arrow Down
        /// </summary>
        VK_DOWN = 0x28,

        /// <summary>
        /// End
        /// </summary>
        VK_END = 0x23,

        /// <summary>
        /// F1
        /// </summary>
        VK_F1 = 0x70,

        /// <summary>
        /// F2
        /// </summary>
        VK_F2 = 0x71,

        /// <summary>
        /// F3
        /// </summary>
        VK_F3 = 0x72,

        /// <summary>
        /// F4
        /// </summary>
        VK_F4 = 0x73,

        /// <summary>
        /// F5
        /// </summary>
        VK_F5 = 0x74,

        /// <summary>
        /// F6
        /// </summary>
        VK_F6 = 0x75,

        /// <summary>
        /// F7
        /// </summary>
        VK_F7 = 0x76,

        /// <summary>
        /// F8
        /// </summary>
        VK_F8 = 0x77,

        /// <summary>
        /// F9
        /// </summary>
        VK_F9 = 0x78,

        /// <summary>
        /// F10
        /// </summary>
        VK_F10 = 0x79,

        /// <summary>
        /// F11
        /// </summary>
        VK_F11 = 0x7A,

        /// <summary>
        /// F12
        /// </summary>
        VK_F12 = 0x7B,

        /// <summary>
        /// F13
        /// </summary>
        VK_F13 = 0x7C,

        /// <summary>
        /// F14
        /// </summary>
        VK_F14 = 0x7D,

        /// <summary>
        /// F15
        /// </summary>
        VK_F15 = 0x7E,

        /// <summary>
        /// F16
        /// </summary>
        VK_F16 = 0x7F,

        /// <summary>
        /// F17
        /// </summary>
        VK_F17 = 0x80,

        /// <summary>
        /// F18
        /// </summary>
        VK_F18 = 0x81,

        /// <summary>
        /// F19
        /// </summary>
        VK_F19 = 0x82,

        /// <summary>
        /// F20
        /// </summary>
        VK_F20 = 0x83,

        /// <summary>
        /// F21
        /// </summary>
        VK_F21 = 0x84,

        /// <summary>
        /// F22
        /// </summary>
        VK_F22 = 0x85,

        /// <summary>
        /// F23
        /// </summary>
        VK_F23 = 0x86,

        /// <summary>
        /// F24
        /// </summary>
        VK_F24 = 0x87,

        /// <summary>
        /// Final
        /// </summary>
        VK_FINAL = 0x18,

        /// <summary>
        /// Help
        /// </summary>
        VK_HELP = 0x2F,

        /// <summary>
        /// Home
        /// </summary>
        VK_HOME = 0x24,

        /// <summary>
        /// Ico00
        /// </summary>
        VK_ICO_00 = 0xE4,

        /// <summary>
        /// Insert
        /// </summary>
        VK_INSERT = 0x2D,

        /// <summary>
        /// Junja
        /// </summary>
        VK_JUNJA = 0x17,

        /// <summary>
        /// Kana
        /// </summary>
        VK_KANA = 0x15,

        /// <summary>
        /// Kanji
        /// </summary>
        VK_KANJI = 0x19,

        /// <summary>
        /// App1
        /// </summary>
        VK_LAUNCH_APP1 = 0xB6,

        /// <summary>
        /// App2
        /// </summary>
        VK_LAUNCH_APP2 = 0xB7,

        /// <summary>
        /// Mail
        /// </summary>
        VK_LAUNCH_MAIL = 0xB4,

        /// <summary>
        /// Media
        /// </summary>
        VK_LAUNCH_MEDIA_SELECT = 0xB5,

        /// <summary>
        /// Left Button
        /// </summary>
        VK_LBUTTON = 0x01,

        /// <summary>
        /// Left Ctrl
        /// </summary>
        VK_LCONTROL = 0xA2,

        /// <summary>
        /// Arrow Left
        /// </summary>
        VK_LEFT = 0x25,

        /// <summary>
        /// Left Alt
        /// </summary>
        VK_LMENU = 0xA4,

        /// <summary>
        /// Left Shift
        /// </summary>
        VK_LSHIFT = 0xA0,

        /// <summary>
        /// Left Win
        /// </summary>
        VK_LWIN = 0x5B,

        /// <summary>
        /// Middle Button
        /// </summary>
        VK_MBUTTON = 0x04,

        /// <summary>
        /// Next Track
        /// </summary>
        VK_MEDIA_NEXT_TRACK = 0xB0,

        /// <summary>
        /// Play / Pause
        /// </summary>
        VK_MEDIA_PLAY_PAUSE = 0xB3,

        /// <summary>
        /// Previous Track
        /// </summary>
        VK_MEDIA_PREV_TRACK = 0xB1,

        /// <summary>
        /// Stop
        /// </summary>
        VK_MEDIA_STOP = 0xB2,

        /// <summary>
        /// Mode Change
        /// </summary>
        VK_MODECHANGE = 0x1F,

        /// <summary>
        /// Page Down
        /// </summary>
        VK_NEXT = 0x22,

        /// <summary>
        /// Non Convert
        /// </summary>
        VK_NONCONVERT = 0x1D,

        /// <summary>
        /// Num Lock
        /// </summary>
        VK_NUMLOCK = 0x90,

        /// <summary>
        /// Jisho
        /// </summary>
        VK_OEM_FJ_JISHO = 0x92,

        /// <summary>
        /// Pause
        /// </summary>
        VK_PAUSE = 0x13,

        /// <summary>
        /// Print
        /// </summary>
        VK_PRINT = 0x2A,

        /// <summary>
        /// Page Up
        /// </summary>
        VK_PRIROR = 0x21,

        /// <summary>
        /// Right Button
        /// </summary>
        VK_RBUTTON = 0x02,

        /// <summary>
        /// Right Ctrl
        /// </summary>
        VK_RCONTROL = 0xA3,

        /// <summary>
        /// Arrow Right
        /// </summary>
        VK_RIGHT = 0x27,

        /// <summary>
        /// Right Alt
        /// </summary>
        VK_RMENU = 0xA5,

        /// <summary>
        /// Right Shift
        /// </summary>
        VK_RSHIFT = 0xA1,

        /// <summary>
        /// Right Win
        /// </summary>
        VK_RWIN = 0x5C,

        /// <summary>
        /// Scroll Lock
        /// </summary>
        VK_SCROLL = 0x91,

        /// <summary>
        /// Sleep
        /// </summary>
        VK_SLEEP = 0x5F,

        /// <summary>
        /// Print Screen
        /// </summary>
        VK_SNAPSHOT = 0x2C,

        /// <summary>
        /// Arrow Up
        /// </summary>
        VK_UP = 0x26,

        /// <summary>
        /// Volume Down
        /// </summary>
        VK_VOLUME_DOWN = 0xAE,

        /// <summary>
        /// Volume Mute
        /// </summary>
        VK_VOLUME_MUTE = 0xAD,

        /// <summary>
        /// Volume Up
        /// </summary>
        VK_VOLUME_UP = 0xAF,

        /// <summary>
        /// X Button 1
        /// </summary>
        VK_XBUTTON1 = 0x05,

        /// <summary>
        /// X Button 2
        /// </summary>
        VK_XBUTTON2 = 0x06
        #endregion
    }
}
