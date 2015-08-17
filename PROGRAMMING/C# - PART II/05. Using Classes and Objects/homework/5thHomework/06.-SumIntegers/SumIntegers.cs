using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string input;
            //Console.WriteLine("Enter the numbers separated by space:");
            //input = Console.ReadLine();
            input = "43 68 9 23 318 -318 -68 -43";
            char separator = ' ';
            string[] arr = input.Split(separator);
            int sum = 0;

            foreach (string str in arr)
            {
                if (str != "")
                {
                    int number = int.Parse(str);
                    sum += number;
                }
                
            }

            Console.WriteLine("The sum is = " + sum);

        }
    }
}
