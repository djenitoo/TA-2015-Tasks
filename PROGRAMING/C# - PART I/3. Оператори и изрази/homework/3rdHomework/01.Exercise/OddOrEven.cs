using System;
//Write an expression that checks if given integer is odd or even

namespace _01.Exercise
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, plesase:");

            int number = int.Parse(Console.ReadLine());     // Declaring the variable

            if (number % 2 == 0)                            // Check if the remainder is equal to ziro, 
            {
                Console.WriteLine("The number is even!");   // if yes then the number is even,
            }
            else                                            // else is odd.
            {
                Console.WriteLine("The number is odd!");
            }
        }
    }
}
