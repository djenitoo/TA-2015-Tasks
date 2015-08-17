using System;
// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine".

namespace _03._LastDigitAsEnglishWord
{
    class LastDigitAsWord
    {
        static void WordReturn(int number)
        {
            string[] numberWords = {
                                       "zero", "one", "two", "three", "four", 
                                       "five", "six", "seven", "eigth", "nine",
                                   };
            for (int i = 0; i < 10; i++)
            {
                if (number == i)
                {
                    Console.WriteLine(numberWords[i]);
                }
            }
        }

        static void Main()
        {
            Console.Write("Please, enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            number = number % 10;

            WordReturn(number);
        }
    }
}
