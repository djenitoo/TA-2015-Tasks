using System;
using System.Text;
// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should
// be filled with '*'. Print the result string into the console.

namespace _05.StringOf20Symbols
{
    class StringOf20Symbols
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder(20);

            Console.WriteLine("Please, enter a string>= 20 symbols: ");
            string text = Console.ReadLine();
            if (text.Length > 20)
            {
                Console.WriteLine("Error! The length is bigger than 20!");
            }
            else
            {
                str.Append(text);
                while (str.Length < 20)
                {
                    str.Append('*');
                }
            }
            Console.WriteLine(str);
        }
    }
}
