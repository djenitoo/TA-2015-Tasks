using System;
using System.Text;
//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:
//              Microsoft announced its next generation PHP compiler today. 
//              It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//The expected result:
//              ********* announced its next generation *** compiler today. 
//              It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.



namespace _09.CensoringText
{
    class CensoringText
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = 
            {
                "PHP", "CLR", "Microsoft"
            };

            Console.WriteLine(ReplaceWithAsterixs(text, words));
        }
        static string ReplaceWithAsterixs(string text, string[] words)
        {
            string result = text;
            for (int i = 0; i < words.Length; i++)
            {
                result = result.Replace(words[i], new string('*', words[i].Length));
            }

            return result;
        }
    }
}
