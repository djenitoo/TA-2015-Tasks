using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double up = (N * N) + (1 / (M * P)) + 1337;
            double down = N - 128.523123123 * P;
            double sin = Math.Sin((int)M % 180);

            double result = (up / down) + sin;

            Console.WriteLine("{0:F6}", result);
        }
    }
}
