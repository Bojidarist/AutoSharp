using System;
using System.Threading;

namespace AutoSharpLibrary.AutoSharpMouse
{
    class MouseInputChecks
    {
        public static void CheckMouseClickInputCoordinates(MouseKeyFlags buttonDownFlag, MouseKeyFlags buttonUpFlag, int x, int y, int millisecondClickDelay, int numberOfClicks = 1)
        {
            if (x != 0 && y != 0)
            {
                CursorInput.SetCursorPos(x, y);

                for (int i = 0; i < numberOfClicks; i++)
                {
                    AutoMouseEvent.MouseEvent(buttonDownFlag, x, y);
                    AutoMouseEvent.MouseEvent(buttonUpFlag, x, y);

                    Thread.Sleep(millisecondClickDelay);
                }
            }
            else
            {
                for (int i = 0; i < numberOfClicks; i++)
                {
                    AutoMouseEvent.MouseEvent(buttonDownFlag);

                    AutoMouseEvent.MouseEvent(buttonUpFlag);

                    Thread.Sleep(millisecondClickDelay);
                }
            }
        }

        public static void CheckMouseInputCoordinates(MouseKeyFlags buttonFlag, int x, int y, int millisecondClickDelay)
        {
            if (x != 0 && y != 0)
            {
                CursorInput.SetCursorPos(x, y);

                AutoMouseEvent.MouseEvent(buttonFlag, x, y);

                Thread.Sleep(millisecondClickDelay);
            }
            else
            {
                AutoMouseEvent.MouseEvent(buttonFlag);

                Thread.Sleep(millisecondClickDelay);
            }
        }
    }
}
