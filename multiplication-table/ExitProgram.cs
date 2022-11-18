using System;

namespace multiplication_table
{
    internal class ExitProgram
    {
        public void Escape()
        {
            Console.WriteLine("\npress any key to exit the process...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
