using System;
// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

namespace _05.Exercise
{
    class Bit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int firstNum = int.Parse(Console.ReadLine());    // Input number.
            int secondNum = 8;

            Console.WriteLine("Bit 3 of the given number is:");
            int bit = (firstNum & secondNum);
            Console.WriteLine((bit !=0) ? 1 : 0);       // The output result.
        }
    }
}
