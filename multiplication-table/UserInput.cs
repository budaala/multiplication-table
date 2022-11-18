using System;

namespace multiplication_table
{
    internal class UserInput
    {
        public int GetNumber(int number)
        {
            try
            {
                number = int.Parse(Console.ReadLine());

                return number;
            }
            catch
            {
                return 0;
            }
        }

        public bool IsValid(int startingNumber, int endingNumber)
        {
            if (startingNumber > endingNumber || startingNumber < 0 || endingNumber < 0) { return false; }
            else { return true; }
        }
    }
}
