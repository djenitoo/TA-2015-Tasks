using System;
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.                             

namespace _13.Exericise
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());

            // ((1U << 3) - 1) e 1 << 3 minus 1

            uint x = ((num >> 3) ^ (num >> 24)) & ((1U << 3) - 1);
            uint r = num ^ ((x << 3) | (x << 24));
            Console.WriteLine(r);
        }
    }
}
