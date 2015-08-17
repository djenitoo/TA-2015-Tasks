using System;
// Write a boolean expression that checks for given integer if it can be 
// divided (without remainder) by 7 and 5 in the same time.


namespace _02.Exericse
{
    class BooleanDivider
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine()); // Declaring the varialbe and it's consle read

            if (number % 5 == 0 && number % 7 == 0)     // Check is the number can be divided w/o remainder by 5 and 7
            {
                Console.WriteLine("The number CAN be divided by 7 & 5 at the same time!"); // If true, then the number it's what we are looking for.
            }
            else
            {
                Console.WriteLine("The number CANNOT be divided by 7 & 5 at the same time!"); // If false, then the number it's not from the ones we are looking for.
            }
        }
    }
}
