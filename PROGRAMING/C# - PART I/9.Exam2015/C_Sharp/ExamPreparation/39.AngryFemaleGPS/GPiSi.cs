using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.AngryFemaleGPS
{
    class GPiSi
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long evenSum = 0;
            long oddSum = 0;
            if (number < 0)
            {
                number *= -1;
            }
            while (number > 0)
            {
                long currNumber = number % 10;
                if (currNumber % 2 == 0)
                {
                    evenSum += currNumber;
                }
                else
                { 
                    oddSum += currNumber;
                }
                number /= 10;
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("right " + evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left " + oddSum);
            }
            else
            {
                Console.WriteLine("straight " + oddSum);
            }
        }
    }
}
