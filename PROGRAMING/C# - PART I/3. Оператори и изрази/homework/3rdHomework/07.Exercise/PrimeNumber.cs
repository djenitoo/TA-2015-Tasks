using System;
// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


namespace _07.Exercise
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number bigger than 0 and lower than 101:");
            int number = int.Parse(Console.ReadLine());     // Input number
            if ((number < 101) && (number > 0))         // check if it is within range
            {
                if (number == 1 || number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0) // if yes, check it's dividers
                {
                    Console.WriteLine("The number is NOT prime !"); // if one or more of them is true then the number is not prime
                }
                else
                {
                    Console.WriteLine("The number IS prime !"); // else is prime
                }
                
            }
            else
            {
                Console.WriteLine("Bad input!"); // else the number is not within range
            }

        }
    }
}
