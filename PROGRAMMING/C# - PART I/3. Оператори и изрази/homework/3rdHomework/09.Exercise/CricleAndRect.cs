using System;
// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 1.5) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).


namespace _09.Exercise
{
    class CricleAndRect
    {
        static void Main(string[] args)
        {
            // Input x,y. I use doble, because the cordinats are not always integer.
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            // Expression that check if the point is within the circle & out or rectangle area. And the output.
            Console.WriteLine(((x-1)*(x-1)+(y-1)*(y-1)<=1.5*1.5) && (((x>=0) && (y>1))||((x<-1) && (y<1))||(((x>=0)||(x<0)) && (y<-1))) ? "The given point IS within the circle and out of the rectangle." : "The point is not withing the circle OR out of the rectangle.");

        }
    }
}
