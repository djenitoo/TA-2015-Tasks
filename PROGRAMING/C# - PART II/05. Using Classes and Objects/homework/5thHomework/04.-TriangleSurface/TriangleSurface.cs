using System;
/*
    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;             //(a*h)/2
        Three sides;                            //[sqrt][s(s-a)(s-b)(s-c)] when s = (a+b+c)/2 (Heron's formula)
        Two sides and an angle between them;    //(1/2) a b sin C 
    Use System.Math.
*/

namespace _04._TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what you will input: \r\nFor side and height enter 1\r\nFor three sides enter 2\r\nFor two sides and angle between them enter 3");
            double result = 0;
            double side1, side2;
            bool wrongInput = false;
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Side one:");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height:");
                    double height = double.Parse(Console.ReadLine());
                    result = (side1 * height) / 2;
                    //Console.WriteLine("Surface is = " + result);
                    break;
                case 2:
                    Console.WriteLine("Side one:");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Side two:");
                    side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Side three:");
                    double side3 = double.Parse(Console.ReadLine());
                    double halfP = (side1 + side2 + side3) / 2;
                    result = Math.Sqrt(halfP * (halfP - side1)*(halfP - side2)*(halfP - side3));
                    //Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Side one:");
                    side1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Side two:");
                    side2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Angle:");
                    double angle = double.Parse(Console.ReadLine());
                    result = (1 / 2) * side1 * side2 * Math.Sin(angle);
                    break;
                default:
                    wrongInput = true;
                    Console.WriteLine("Wrong input!");
                    break;
            }
            if (!wrongInput)
            {
                Console.WriteLine("Surface of triangle is = " + result);
            }
            
        }
    }
}
