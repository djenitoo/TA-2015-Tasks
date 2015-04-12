using System;
// Sort 3 real values in descending order using nested if statements.

namespace _04.Exercise
{
    class SortingWithNestedIf
    {
        static void Main(string[] args)
        {
            // Input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double first, second, third;

            if (a > b)
            {
                first = a;
                second = b;
                if (a > c && b > c)
                {
                    third = c;
                }
                else
                {
                    if (a < c)
                    {
                        first = c;
                        second = a;
                        third = b;
                    }
                    else
                    {
                        second = c;
                        third = b;
                    }
                }
            }
            else
            {
                first = b;
                second = a;

                if (b > c && a > c)
                {
                    third = c;
                }
                else
                {
                    if (b < c)
                    {
                        first = c;
                        second = b;
                        third = a;
                    }
                    else
                    {
                        second = c;
                        third = a;
                    }
                }
            }
            Console.WriteLine("First: {0}\n\rSecond: {1}\n\rThird: {2}",first,second,third);
        }
    }
}
