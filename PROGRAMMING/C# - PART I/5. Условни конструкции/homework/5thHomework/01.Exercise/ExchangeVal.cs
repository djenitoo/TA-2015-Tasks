using System;
//Write an if statement that examines two double variables and exchanges 
//their values if the first one is greater than the second one.


namespace _01.Exercise
{
    class ExchangeVal
    {
        static void Main(string[] args)
        {
            // Input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            // New variable that gets the value of a
            double temp = a;
            // Check if b is greater than max val
            if (a > b)
            {
                a = b;
                b = temp;
            }
            // Output
            Console.WriteLine(a + " " + b);
        }
    }
}
