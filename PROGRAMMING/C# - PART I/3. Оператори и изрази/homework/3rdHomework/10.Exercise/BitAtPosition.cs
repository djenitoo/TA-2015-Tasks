using System;
// Write a boolean expression that returns if the bit at position p (counting from 0) 
// in a given integer number v has value of 1. Example: v=5; p=1  false.


namespace _10.Exercise
{
    class BitAtPosition
    {
        static void Main(string[] args)
        {
            // Input v,p
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            // 1 << p
            int mask = 1 << p;
            // Check with &, and output.
            Console.Write("The bit at position {0} is 1:", p);
            Console.WriteLine((v & mask) != 0 ? "True." : "False.");
        }
    }
}
