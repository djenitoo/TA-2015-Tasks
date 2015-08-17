using System;
// Write a program that, depending on the user's choice inputs int, 
// double or string variable. If the variable is integer or double, 
// increases it with 1. If the variable is string, appends "*" at its end. 
// The program must show the value of that variable as a console output.
// Use switch statement.


namespace _08.Exercise
{
    class ChoiseInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose what will be your input. \r\nFor integer - 1, for double - 2 and for string - 3.");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                {
                    Console.Write("Please enter your input: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("You choose integer. {0} + 1 = {1}", b, (b + 1));
                    break;
                 }
                case 2:
                {
                    Console.Write("Please enter your input: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("You choose double input. {0} + 1 = {1}", b, (b + 1));
                    break;
                }
                case 3:
                {
                    Console.Write("Please enter your input: ");
                    string b = Console.ReadLine();
                    Console.WriteLine("You choose string input. {0} + * = {1}", b, (b + "*"));
                    break;
                }
                default:
                Console.WriteLine("Bad input!");
                    break;
            }
        }
    }
}
