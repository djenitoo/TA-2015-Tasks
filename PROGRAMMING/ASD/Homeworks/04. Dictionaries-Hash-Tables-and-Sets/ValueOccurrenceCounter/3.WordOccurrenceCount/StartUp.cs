using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
Write a program that counts how many times each word from given text file words.txt appears in it. 
The character casing differences should be ignored. 
The result words should be ordered by their number of occurrences in the text. 
Example:

This is the TEXT. Text, text, text – THIS TEXT! Is this the text?

    is -> 2

    the -> 2

    this -> 3

    text -> 6

*/
namespace _3.WordOccurrenceCount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var db = File.ReadAllText(@"..\\..\\words.txt");
            var words = (Regex.Replace(db, @"[^\w\s]", String.Empty)).Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(w=> w.ToLower()).ToArray();
            var occurrenceDict = new Dictionary<string,int>();

            foreach (var word in words)
            {
                if (!occurrenceDict.ContainsKey(word))
                {
                    occurrenceDict.Add(word, 0);
                }

                occurrenceDict[word] = occurrenceDict[word] + 1;
            }

            foreach (var pair in occurrenceDict.OrderBy(w=>w.Value))
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
