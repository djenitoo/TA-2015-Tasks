using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 0; i < N; i++)
            {
                text += (Console.ReadLine()) + " ";
            }
            string[] sep = {" ", " "};
            string[] words = text.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            PutsWordOnLine(words, W);
        }

        static void PutsWordOnLine(string[] words, int lineLen)
        {
            int i = 0;
            while (i < words.Length)
            {
                StringBuilder line = new StringBuilder();
                int currTakenLen = 0;
                int wordsOnRow = 0;
                if (line.Length == 0)
                {
                    line.Append(words[i]);
                    currTakenLen += words[i].Length;
                    wordsOnRow++;
                    i++;
                }
                while ((i < words.Length) && ((lineLen - (currTakenLen + 1)) >= words[i].Length))
                {
                    line.Append(' ');
                    line.Append(words[i]);
                    currTakenLen += words[i].Length + 1;
                    wordsOnRow++;
                    i++;

                }
                Console.WriteLine(Justification(line, lineLen, wordsOnRow));
            }
        }

        static StringBuilder Justification(StringBuilder line, int lineLen, int wordsOnRow)
        {
            int i = 1;
            while ((line.Length < lineLen) && wordsOnRow != 1)
            {
                if ((line[i] == ' ') && (line[i - 1] != ' '))
                {
                    line.Insert(i, ' ');
                }
                if (i == line.Length - 1)
                {
                    i = 1;
                }
                else
                {
                    i++;
                } 
            }

            return line;
        }
    }
}
