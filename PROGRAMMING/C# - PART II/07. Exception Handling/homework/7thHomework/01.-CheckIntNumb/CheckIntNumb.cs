using System;
// Write a program that reads an integer number and calculates
// and prints its square root. If the number is invalid or negative, 
// print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

namespace _01._CheckIntNumb
{
    class CheckIntNumb
    {
        static void Main()
        {
            int number;
            try
            {
                string line = Console.ReadLine();
                number = int.Parse(line);
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("Square roof of {0} is: {1}", number, Math.Sqrt(number));

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
