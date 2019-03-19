using AutoSharpLibrary;

namespace AutoSharpConsoleUI
{
    class Bootstrap
    {
        public static void Boot()
        {
            // Start delay
            for (int i = 5; i >= 1; i--)
            {
                System.Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }

            // Test
            string input = "2*5*5{Divide}5*5*5{Enter}";
            AutoSharpKeyboardInput.SendKeyboardInputToWindow(input, "Calculator", 1000);
        }
    }
}
