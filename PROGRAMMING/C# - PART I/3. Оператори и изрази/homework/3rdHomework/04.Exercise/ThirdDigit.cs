using System;
// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

namespace _04.Exercise
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number:");
            int number = int.Parse(Console.ReadLine());     // Defining the variable.
            number = number / 100;      // We devide the number by 100
            number = number % 10;       // We get the remainder of dividing be 10
            if (number == 7)            // if it's 7
            {
                Console.WriteLine("The third digit (right-to-left) of the number is 7 !"); // that's what we are looking for
            }
            else
            {
                Console.WriteLine("The third digit (right-to-left) of the number is NOT 7 !"); // else is not.
            }

        }
    }
}
