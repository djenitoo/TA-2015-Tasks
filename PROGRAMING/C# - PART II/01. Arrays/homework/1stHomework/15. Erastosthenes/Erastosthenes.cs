using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

namespace _15.Erastosthenes
{
    class Erastosthenes
    {
        static void Main()
        {
            int limit = 10000000 - 1;
            int blank = -1;                                 // We declare some variable that we will use to mark the number that are not primes. First I tried with null, but there were some errors, so I use -1 (which is never used in our range of numbers).
            List<int> numbers = new List<int>(limit);       // The list will hold 10M numbers without 1, we will begin from 2
            List<int> primes = new List<int>();
            for (int i = 0; i < limit; i++)         
            {
                numbers.Add(i + 2);                   // We want to begin with 2, not 1
            }
            int lastPrime = 0;
            int index = 0;
            while ((lastPrime = numbers[index]) <= Math.Sqrt(limit))
            {
                if (lastPrime != -1)                                                //
                {                                                                   //
                    for (int i = lastPrime + index; i < limit; i += lastPrime)      //
                    {                                                               // the algorithm
                        numbers[i] = (int)blank;                                    //this numbers that are not prime get value of -1
                    }                                                               //
                }                                                                   //
                index++;                                                            //
            }
            for (int i = 0; i < limit; i++)                                         // Here we move in new list this numbers that are not -1
            {
                if (numbers[i] != blank)
                {
                    primes.Add(numbers[i]);
                }
            }
            foreach (int number in primes)                                          // Output the new list
            {
                Console.Write(number + ", ");
            }

        }
    }
}
