using System;
// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.


namespace _02.Print_Numbers_to_N___3_7
{
    class NotDivTo3And7
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if ((i%3 != 0) && (i%7 != 0))
                {
                    Console.Write(i+" ");
                }
                i++;
            }
            Console.WriteLine();
        }
    }
}
