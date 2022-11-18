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

            Console.WriteLine("Podaj liczbę, od której chcesz rozpocząć rysowanie tabliczki mnożenia: ");
            startingNumber = uInput.GetNumber(startingNumber);

            Console.WriteLine("Podaj liczbę, na której chcesz zakończyć rysowanie tabliczki mnożenia: ");
            endingNumber = uInput.GetNumber(endingNumber);

            Console.WriteLine();

            if (!uInput.IsValid(startingNumber, endingNumber))
            {
                Console.WriteLine("Podano niewłaściwy zakres. Spróbuj ponownie uruchomić program.");
                e.Escape();
            }

            drawing.TimesTable(startingNumber, endingNumber);

            Console.WriteLine();

            e.Escape();
        }
    }
}
