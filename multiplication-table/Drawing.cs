using System;

namespace multiplication_table
{
    internal class Drawing
    {
        public void TimesTable(int startingNumber, int endingNumber)
        {
            int intRange = endingNumber - startingNumber + 1;
            int[] ints = new int[intRange];

            for (int i = 0; i < intRange; i++)
            {
                ints[i] = startingNumber;
                startingNumber++;
            }

            // horizontal header
            Console.Write("  ");
            for (int i = 0; i < intRange; i++)
            {
                Console.Write(ints[i] + " |");
            }

            for (int j = 0; j < intRange; j++)
            {
                Console.WriteLine();
                Console.Write(ints[j]);
                for (int i = 0; i < intRange; i++)
                {
                    Console.Write(" ");
                    Console.Write(ints[i] * ints[j]);
                }
            }
        }
    }
}