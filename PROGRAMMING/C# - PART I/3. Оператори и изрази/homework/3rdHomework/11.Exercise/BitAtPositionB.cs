using System;
// Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

namespace _11.Exercise
{
    class BitAtPositionB
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int mask = 1 << b;
            int iAndmask = i & mask;
            int bit = iAndmask >> b;
            Console.WriteLine("The bit at position {0} is: {1}", b, bit);
        }
    }
}
