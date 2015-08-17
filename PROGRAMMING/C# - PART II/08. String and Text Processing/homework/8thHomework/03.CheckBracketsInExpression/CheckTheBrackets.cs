using System;
// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).


namespace _03.CheckBracketsInExpression
{
    class CheckTheBrackets
    {
        static void Main()
        {
            Console.Write("Enter expression: ");
            string expression = Console.ReadLine();

            if (CheckBrackets(expression) == 0)
            {
                Console.WriteLine("All brackets are propertly closed!");
            }
            else
            {
                Console.WriteLine("The brackets are NOT propertly closed!");
            }
        }

        static int CheckBrackets(string expression)
        {
            int countOfBrackets = 0; // The idea if of jasssonpet https://github.com/jasssonpet/TelerikAcademy/blob/master/Programming/2.CSharpPartTwo/8.StringsAndTextProcessing/3.CheckBrackets/Program.cs

            foreach (char ch in expression)
            {
                if (ch == '(')
                {
                    countOfBrackets++;
                }
                else if (ch == ')')
                {
                    countOfBrackets--;
                }
            }

            return countOfBrackets;
        }
    }
}
