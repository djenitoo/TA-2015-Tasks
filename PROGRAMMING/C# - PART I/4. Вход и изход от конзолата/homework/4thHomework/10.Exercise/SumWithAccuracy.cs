using System;
// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

namespace _10.Exercise
{
    class SumWithAccuracy
    {
        static void Main(string[] args)
        {
            decimal up = 1m;
            decimal down = 2m;
            decimal sum = 0m;
            int sign = 1;
            int count = 0;
            while (up/down > 0.001m)
            {
                sum = sum + (up/ down)*sign;
                sign = sign * (-1);
                down++;
            }
            Console.WriteLine("{0:0.000}",sum);
        }
    }
}
