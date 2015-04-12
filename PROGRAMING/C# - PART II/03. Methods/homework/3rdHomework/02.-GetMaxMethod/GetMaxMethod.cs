using System;
// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


namespace _02._GetMaxMethod
{
    class GetMaxMethod
    {
        static int GetMax(int number1, int number2)
        {
            if (number1 >= number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
            
        }
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            int midMax = GetMax(number1, number2);
            Console.WriteLine("----------------------------");
            Console.WriteLine("The max number is: " + GetMax(midMax, number3));
            Console.WriteLine("----------------------------");
        }
    }
}
