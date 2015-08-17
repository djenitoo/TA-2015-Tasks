using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H =   int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());
            int res = 0;

            Cy1 = (2 * H) - Cy1;
            Cy2 = (2 * H) - Cy2;
            Cy3 = (2 * H) - Cy3;

            int minX = Math.Min(Sx1, Sx2);
            int maxX = Math.Max(Sx1, Sx2);
            int minY = Math.Min(Sy1, Sy2);
            int maxY = Math.Max(Sy1, Sy2);
            // Angles
            if ((Cx1 == minX || Cx1 == maxX) && (Cy1 == minY || Cy1 == maxY))
            {
                res += 25;
            }
            if ((Cx2 == minX || Cx2 == maxX) && (Cy2 == minY || Cy2 == maxY))
            {
                res += 25;
            }
            if ((Cx3 == minX || Cx3 == maxX) && (Cy3 == minY || Cy3 == maxY))
            {
                res += 25;
            }

            // Sides
            if ((Cx1 == minX || Cx1 == maxX) && ((Cy1 < maxY) && (Cy1 > minY)) ||
                ((Cy1 == minY || Cy1 == maxY) && ((Cx1 < maxX) && (Cx1 > minX))))
            {
                res += 50;
            }
            if ((Cx2 == minX || Cx2 == maxX) && ((Cy2 < maxY) && (Cy2 > minY)) ||
                ((Cy2 == minY || Cy2 == maxY) && ((Cx2 < maxX) && (Cx2 > minX))))
            {
                res += 50;
            }
            if ((Cx3 == minX || Cx3 == maxX) && ((Cy3 < maxY) && (Cy3 > minY)) ||
                ((Cy3 == minY || Cy3 == maxY) && ((Cx3 < maxX) && (Cx3 > minX))))
            {
                res += 50;
            }

            // Inside
            if ((Cx1 < maxX && Cx1 > minX) && (Cy1 < maxY && Cy1 > minY))
            {
                res += 100;
            }
            if ((Cx2 < maxX && Cx2 > minX) && (Cy2 < maxY && Cy2 > minY))
            {
                res += 100;
            }
            if ((Cx3 < maxX && Cx3 > minX) && (Cy3 < maxY && Cy3 > minY))
            {
                res += 100;
            }

            Console.WriteLine(res + "%");
        }
    }
}
