using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary. 
namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            string[] dictionary = 
            {
                ".NET – platform for applications from Microsoft",
                "CLR – managed execution environment for .NET",
                "namespace – hierarchical organization of classes"
            };
            string word = "clr";
            foreach (string item in dictionary)
            {
                if (item.IndexOf(word + " –", StringComparison.OrdinalIgnoreCase) == 0) // Idea of http://pastebin.com/R9L2t4KU
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
