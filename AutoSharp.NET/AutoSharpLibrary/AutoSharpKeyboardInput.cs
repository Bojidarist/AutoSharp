using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace AutoSharpLibrary
{
    public class AutoSharpKeyboardInput
    {
        #region SendKeyboardInput
        /// <summary>
        /// Sends keyboard input.
        /// </summary>
        /// <param name="keysToPress">Keys to press.</param>
        /// <param name="millisecondDelay">Delay in milliseconds.</param>
        public static void SendKeyboardInput(string keysToPress, int millisecondDelay = 0)
        {
            StringBuilder sb = new StringBuilder();
            bool isInBrackets = false;

            foreach (char key in keysToPress)
            {
                switch (key)
                {
                    case '{':
                        sb.Append(key);
                        isInBrackets = true;
                        break;

                    case '}':
                        sb.Append(key);
                        isInBrackets = false;
                        SendKeys.SendWait(sb.ToString());
                        sb.Clear();
                        Thread.Sleep(millisecondDelay);
                        break;

                    default:
                        if (isInBrackets == true)
                        {
                            sb.Append(key.ToString());
                        }
                        else
                        {
                            SendKeys.SendWait(key.ToString());
                            Thread.Sleep(millisecondDelay);
                        }
                        break;
                }
            }
            sb.Clear();
        }
        #endregion

        #region SendKeyboardInputToWindow
        /// <summary>
        /// Sends keyboard input to specific process.
        /// </summary>
        /// <param name="keysToPress">Keys to press.</param>
        /// <param name="processName">Process name.</param>
        /// <param name="millisecondDelay">Delay in milliseconds.</param>
        public static void SendKeyboardInputToWindow(string keysToPress, string processName, int millisecondDelay = 0)
        {
            StringBuilder sb = new StringBuilder();
            WindowManagement.SetForegroundWindow(processName);
            bool isInBrackets = false;

            foreach (char key in keysToPress)
            {
                switch (key)
                {
                    case '{':
                        sb.Append(key);
                        isInBrackets = true;
                        break;

                    case '}':
                        sb.Append(key);
                        isInBrackets = false;
                        SendKeys.SendWait(sb.ToString());
                        sb.Clear();
                        Thread.Sleep(millisecondDelay);
                        break;

                    default:
                        if (isInBrackets == true)
                        {
                            sb.Append(key.ToString());
                        }
                        else
                        {
                            SendKeys.SendWait(key.ToString());
                            Thread.Sleep(millisecondDelay);
                        }
                        break;
                }
            }
            sb.Clear();
        }
        #endregion
    }
}
