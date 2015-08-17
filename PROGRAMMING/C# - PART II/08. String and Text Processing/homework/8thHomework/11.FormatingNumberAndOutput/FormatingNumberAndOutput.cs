using System;
using System.Text;
//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

namespace _11.FormatingNumberAndOutput
{
    class FormatingNumberAndOutput
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:0.00%}", number);
            Console.WriteLine("{0,15:0.###E+0}", number);
        }
    }
}
