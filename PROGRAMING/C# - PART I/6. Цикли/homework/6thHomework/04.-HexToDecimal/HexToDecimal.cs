using System;
using System.Collections.Generic;
// Write a program to convert hexadecimal numbers to their decimal representation.


namespace _04._HexToDecimal
{
    class HexToDecimal
    {
        

        static void Main()
        {
            Console.Write("Enter a hexadecimal number: ");
            string hexNumber = Console.ReadLine().ToUpper();

            Console.WriteLine("-----------------------------------");
            Console.Write("The decimal representation of {0} is: ", hexNumber);
            ConvertHexToDecimal(hexNumber);
            Console.WriteLine("-----------------------------------");
        }

        static void ConvertHexToDecimal(string number)
        {
            long result = 0;
            long power = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    result = result + (((int)number[i] - 48) * (int)Math.Pow(16, power));
                    power--;
                }
                if (number[i] == 'A')
                {
                    result = result + (10 * (int)Math.Pow(16, power));
                    power--;
                }
                if (number[i] == 'B')
                {
                    result = result + (11 * (int)Math.Pow(16, power));
                    power--;
                }
                if (number[i] == 'C')
                {
                    result = result + (12 * (int)Math.Pow(16, power));
                    power--;
                }
                if (number[i] == 'D')
                {
                    result = result + (13 * (int)Math.Pow(16, power));
                    power--;
                }
                if (number[i] == 'E')
                {
                    result = result + (14 * (int)Math.Pow(16, power));
                    power--;
                }
                if (number[i] == 'F')
                {
                    result = result + (15 * (int)Math.Pow(16, power));
                    power--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
