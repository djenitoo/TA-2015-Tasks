using System;

namespace _20.Cartesian_Coordinate_System
{
    class CordSys
    {
        static void Main()
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            if ((X == 0) && (Y == 0))
            {
                Console.WriteLine(0);
            }
            else if ((X > 0) && (Y > 0))
            {
                Console.WriteLine(1);
            }
            else if ((X < 0) && (Y > 0))
            {
                Console.WriteLine(2);
            }
            else if ((X < 0) && (Y < 0))
            {
                Console.WriteLine(3);
            }
            else if ((X > 0) && (Y < 0))
            {
                Console.WriteLine(4);
            }
            else if ((X == 0) && ((Y > 0) || (Y < 0)))
            {
                Console.WriteLine(5);
            }
            else if (((X > 0) || (X < 0)) && (Y == 0))
            {
                Console.WriteLine(6);
            }
        }
    }
}
