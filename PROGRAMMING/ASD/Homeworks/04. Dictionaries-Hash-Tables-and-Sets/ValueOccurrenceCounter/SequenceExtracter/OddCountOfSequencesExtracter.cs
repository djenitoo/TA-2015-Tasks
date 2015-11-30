using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
{C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
*/
namespace SequenceExtracter
{
    class OddCountOfSequencesExtracter
    {
        static void Main(string[] args)
        {
            string sampleInput = "C#, SQL, PHP, PHP, SQL, SQL";
            string[] inputCollection = sampleInput.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            var wordDictionary = new Dictionary<string, int>();

            foreach (var word in inputCollection)
            {
                if (wordDictionary.ContainsKey(word))
                {
                    wordDictionary[word] = wordDictionary[word] + 1;
                }
                else
                {
                    wordDictionary.Add(word, 1);
                }
            }

            var oddOccurrencedWords = new List<string>();
            foreach (var word in wordDictionary)
            {
                if (word.Value % 2 != 0)
                {
                    oddOccurrencedWords.Add(word.Key);
                }
            }
            Console.WriteLine("Input:");
            Console.WriteLine("{" + sampleInput + "}");
            Console.WriteLine("Words with odd occurrence: ");

            Console.WriteLine("{" + string.Join(", ", oddOccurrencedWords) + "}");
        }
    }
}
