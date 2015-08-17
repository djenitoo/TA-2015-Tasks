using System;
// We are given 5 integer numbers. Write a program that checks if the sum 
// of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.


namespace _09.Exercise   
{
    class ChecksSumOfInts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the five integer numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter subset, example 153:");
            int input = int.Parse(Console.ReadLine());
            int x;
            int sum = 0;
            while (input > 0)
            {
                x = input % 10;
                input /= 10;

                if (x == 1 || x == 2 || x == 3 || x==4)
                {
                    if (x==1 || x==2 || x==3)
                    {
                        if (x==1 || x==2)
                        {
                            if (x == 1)
                            {
                                x = a;
                            }
                            else
                            {
                                x = b;
                            }
                        }
                        else
                        {
                            x = c;
                        }
                    }
                    else
                    {
                        x = d;
                    }
                }
                else
                {
                    x = e;
                }
                sum += x;
            }
            if (sum == 0)
            {
                Console.WriteLine("The sum of the chosen subset of numbers is equal to zero!");
            }
            else
            {
                Console.WriteLine("The sum of the chosen subset of numbers is NOT equal to zero, but it's = {0}", sum);
            }
        }


    }
}
