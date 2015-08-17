using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.FighterAttact
{
    class FighterAttact
    {
        static void Main(string[] args)
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine());
            int Py2 = int.Parse(Console.ReadLine());
            int Fx = int.Parse(Console.ReadLine());
            int Fy = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int minX = Math.Min(Px1, Px2);
            int maxX = Math.Max(Px1, Px2);
            int minY = Math.Min(Py1, Py2);
            int maxY = Math.Max(Py1, Py2);

            Fx += D;
            int result = 0;

            // Check if bomb is part of rect
            if ((Fx >= minX && Fx <= maxX) && (Fy >= minY && Fy <= maxY))
            {
                result += 100;
            }
            //Check front cell
            if ((Fx+1 >= minX && Fx+1 <= maxX) && (Fy >= minY && Fy <= maxY))
            {
                result += 75;
            }
            //Check up
            if ((Fy+1 >= minY && Fy+1 <= maxY) && (Fx >= minX && Fx <= maxX))
            {
                result += 50;
            }
            //Check down
            if ((Fy-1 >= minY && Fy-1 <= maxY) && (Fx >= minX && Fx <= maxX))
            {
                result += 50;
            }

            Console.WriteLine(result + "%");
        }
    }
}
