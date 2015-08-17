using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.PieceOfCake
{
    class PieceOfCake
    {
        static void Main(string[] args)
        {
            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());
            decimal D = decimal.Parse(Console.ReadLine());

            
            decimal wholeCakes = (A / B) + (C / D);
            
            if (wholeCakes >= 1)
            {
                Console.WriteLine("{0}", (int)wholeCakes);
            }
            else
            {
                Console.WriteLine("{0:F22}", wholeCakes); 
            }

            decimal over = (A * D) + (C * B);
            decimal down = B * D;

            Console.WriteLine(over + "/" + down);

        }
    }
}
