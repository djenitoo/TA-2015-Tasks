using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MagicWords
{
    class MagicWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                string curr = Console.ReadLine();
                words.Add(curr);
            }
            words = Reorder(words);
            Print(words);
        }

        static List<string> Reorder(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                int position = words[i].Length % (words.Count + 1);
                string word = words[i];
                words[i] = null;
                words.Insert(position, word);
                words.Remove(null);
            }

            return words;
        }

        static void Print(List<string> words)
        {
            int max = 0;
            foreach (string item in words)
            {
                if (item.Length > max)
                {
                    max = item.Length;
                }
            }

            // -----------------------
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (i < words[j].Length)
                    {
                        result.Append(words[j][i]);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
