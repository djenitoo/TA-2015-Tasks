using System;
using System.Collections.Generic;

// Write a program to convert decimal numbers to their binary representation.

namespace _01._DecimalToBinary
{
    class DecimalToBinary
    {
        static void ConvertDecimalToBinary(long number)
        {
            string result = "";
            while (number > 0)
            {
                long mask = number % 2;
                result = mask.ToString() + result;
                number = number / 2;
            }
            
            Console.WriteLine(result);
        }

        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            Console.Write("The binary representation of {0} is: ", number);
            ConvertDecimalToBinary(number);
            Console.WriteLine("-----------------------------------");
        }
    }
}
