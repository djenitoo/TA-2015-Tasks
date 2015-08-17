using System;
// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace _01._IfLeapYear
{
    class IfLeapYear
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} its a leap year!", year);
            }
            else
            {
                Console.WriteLine("{0} its NOT a leap year!", year);
            }
        }
    }
}
