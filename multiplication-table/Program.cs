using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uInput = new UserInput();
            var e = new ExitProgram();
            var drawing = new Drawing();

            int startingNumber = 0;
            int endingNumber = 0;

            Console.WriteLine("Input the number from which the table should start: ");
            startingNumber = uInput.GetNumber(startingNumber);

            Console.WriteLine("Input the number at which the table should end: ");
            endingNumber = uInput.GetNumber(endingNumber);

            Console.WriteLine();

            if (!uInput.IsValid(startingNumber, endingNumber))
            {
                Console.WriteLine("Invalid input. Please try again!");
                e.Escape();
            }

            drawing.TimesTable(startingNumber, endingNumber);

            Console.WriteLine();

            e.Escape();
        }
    }
}
