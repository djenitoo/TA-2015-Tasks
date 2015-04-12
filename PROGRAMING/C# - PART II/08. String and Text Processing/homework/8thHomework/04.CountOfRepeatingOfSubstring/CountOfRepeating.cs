using System;
using System.Text.RegularExpressions;

namespace _04.CountOfRepeatingOfSubstring
{
    class CountOfRepeating
    {
        static void Main()
        {
            //Console.WriteLine("Please, enter a text where to search:");
            //string text = Console.ReadLine();

            //Console.WriteLine("Please, enter a sentence which we will search:");
            //string sentence = Console.ReadLine();
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string sentence = "in";

            Console.WriteLine("The count is: " + Regex.Matches(text, sentence, RegexOptions.IgnoreCase).Count);
        }
    }
}
