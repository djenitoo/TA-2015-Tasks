using System;
using System.Collections.Generic;
//Write a program to convert binary numbers to their decimal representation.

namespace _02._BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void ConvertBinaryToDecimal(string number)
        {
            ulong result = 0;
            int power = 0;
            int i = number.Length-1;
            ulong mask;
            while (i > -1)
            {
                if (number[i] != '0')
                {
                    mask = 1;
                }
                else
                {
                    mask = 0;
                }
                result = result + (mask * (ulong)Math.Pow(2, power));
                power++;
                i--;
            }
            Console.WriteLine(result);
        }
        static void Main()
        {
            Console.Write("Enter a binary number: ");
            string number = Console.ReadLine();

            Console.WriteLine("-----------------------------------");
            Console.Write("The decimal representation of {0} is: ", number);
            ConvertBinaryToDecimal(number);
            Console.WriteLine("-----------------------------------");
            
        }
    }
}
