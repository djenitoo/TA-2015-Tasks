using System;
// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

namespace _02.ReverseAndPrintString
{
    class ReverseAndPrintString
    {
        static void Main()
        {
            Console.Write("Please, enter a string for reversion: ");
            string text = Console.ReadLine();

            Console.WriteLine("{0} reversed is: {1}.", text, ReverseString(text));
            
        }
        static string ReverseString(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
