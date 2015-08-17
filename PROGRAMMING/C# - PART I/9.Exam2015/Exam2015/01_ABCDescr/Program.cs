using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ABCDescr
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());

            decimal max = Math.Max(A, B);
            max = Math.Max(max, C);

            Console.WriteLine(max);

            decimal min = Math.Min(A, B);
            min = Math.Min(min, C);

            Console.WriteLine(min);

            decimal aritmeticMean = (A + B + C) / 3;

            Console.WriteLine("{0:F3}", aritmeticMean);
        }
    }
}
