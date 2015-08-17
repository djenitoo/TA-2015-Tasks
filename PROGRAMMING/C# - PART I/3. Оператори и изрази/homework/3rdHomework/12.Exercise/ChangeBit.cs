using System;
// We are given integer number n, value v (v=0 or 1) and a position p. 
// Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)


namespace _12.Exercise
{
    class ChangeBit
    {
        static void Main(string[] args)
        {
            int nAndmask;
            // Input the number
            Console.WriteLine("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            // and the value
            Console.WriteLine("Please, enter 0 or 1:");
            int v = int.Parse(Console.ReadLine());
            // if the value it's not 0 or 1 - Bad input
            if (v != 0 && v != 1)
            {
                Console.WriteLine("Bad input !");
            }
            // else we modify the number
            else
            {
                // input a position
                Console.WriteLine("Please, enter a position:");
                int p = int.Parse(Console.ReadLine());
                // if it's 1 then we mask 1<<p, and | n and mask
                if (v == 1)
                {
                    int mask = 1 << p;
                    nAndmask = n | mask;
                }
                // else our mask is !(1 and p), and then we & n and mask
                else
                {
                    int mask = ~(1 << p);
                    nAndmask = n & mask;
                }
                // The output.
                Console.WriteLine("The result is: {0}", nAndmask);
            }
        }
    }
}
