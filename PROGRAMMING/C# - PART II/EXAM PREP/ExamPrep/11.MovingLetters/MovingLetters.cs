using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MovingLetters
{
    class MovingLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder words = new StringBuilder();
            int maxSymbols = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxSymbols)
                {
                    maxSymbols = array[i].Length;
                }
            }
            for (int i = 1; i <= maxSymbols; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j].Length - i >= 0)
                    {
                        words.Append(array[j][array[j].Length - i]);
                    }
                }
            }
            Console.WriteLine(MoveLetters(words));
            
        }

        static StringBuilder MoveLetters(StringBuilder text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                int moves = char.ToLower(text[i]) - 'a' + 1;
                int pos = (moves + i) % text.Length;
                text = text.Remove(i, 1);
                text = text.Insert(pos, symbol.ToString());
            }

            return text;
        }
    }
}
