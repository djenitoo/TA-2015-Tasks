using System;
//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

namespace _03.Exercise
{
    class Comparing
    {
        static void Main(string[] args)
        {
            // The comparison is prefered to be done with decimal type,
            //but the requested precision of the comparison is 0.0000001, so we can also use float.
            Console.WriteLine("Please enter the first number:");
            float firstNumber = float.Parse(Console.ReadLine()); // Input of the first number for comparing, please use ',' not '.'
            Console.WriteLine("Please enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine()); // Input of the second number for comparing, please use ',' not '.'
            if (firstNumber == secondNumber) Console.WriteLine("{0} and {1} are equal!",firstNumber,secondNumber); // Output if the numbers are equal
            else Console.WriteLine("{0} and {1} are not equal!", firstNumber, secondNumber); // Output if the numbers are not equal

        }
    }
}
