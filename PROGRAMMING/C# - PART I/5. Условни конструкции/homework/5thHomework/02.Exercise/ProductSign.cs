using System;
// Write a program that shows the sign (+ or -) of the product of three real numbers 
// without calculating it. Use a sequence of if statements.


namespace _02.Exercise
{
    class ProductSign
    {
        static void Main(string[] args)
        {
            // Input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // The sequence of if statements & output
            Console.WriteLine("The sign of the product of {0}, {1} and {2} is:", a, b, c);
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a >= 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if(a <= 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b <= 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b >= 0 && c <= 0)
            {
                Console.WriteLine("-");
            }
            else if (a <= 0 && b <= 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if (a <= 0 && b >= 0 && c <= 0)
            {
                Console.WriteLine("+");
            }
            else if (a >= 0 && b <= 0 && c <= 0)
            {
                Console.WriteLine("+");
            }
            else if (a <= 0 && b <= 0 && c <= 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
