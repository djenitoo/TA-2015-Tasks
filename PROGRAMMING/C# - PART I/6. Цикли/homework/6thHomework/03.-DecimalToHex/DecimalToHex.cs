using System;
using System.Collections.Generic;
// Write a program to convert decimal numbers to their hexadecimal representation.

namespace _03._DecimalToHex
{
    class DecimalToHex
    {
        static void ConvertDecimalToHex(long number)
        {
            List<string> list = new List<string>();
            while (number > 0)
	        {
	            long mask = number % 16;
                if (mask >= 0 && mask <= 9)
                {
                    list.Add(mask.ToString());
                }
                if (mask == 10)
	            {
		            list.Add("A");
	            }
                if (mask == 11)
	            {
		            list.Add("B");
	            }
                if (mask == 12)
	            {
		            list.Add("C");
	            }
                if (mask == 13)
	            {
		            list.Add("D");
	            }
                if (mask == 14)
	            {
		            list.Add("E");
	            }
                if (mask == 15)
	            {
		            list.Add("F");
	            }
                number = number / 16;
	        }
            list.Reverse();
            foreach (string nums in list)
            {
                Console.Write(nums);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            long decimalNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.Write("The Hexadecimal representation of {0} is: ", decimalNumber);
            ConvertDecimalToHex(decimalNumber);
            Console.WriteLine("-----------------------------------");
        }
    }
}
