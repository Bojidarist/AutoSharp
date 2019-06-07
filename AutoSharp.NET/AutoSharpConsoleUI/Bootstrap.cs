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
            QuickTests.KeyboardInputTest();
            //QuickTests.MouseInputTest();

            System.Console.WriteLine("Done");
        }
    }
}
