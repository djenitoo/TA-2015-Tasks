using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given a text. Write a program that changes the text in all 
//regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
// We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05.ToUpper
{
    class ToUpper
    {
        static void Main()
        {
            //Console.WriteLine("Enter a text: ");
            //string text = Console.ReadLine();
            string text = "<upcase>We are living</upcase> in a <upcase>yellow submarine</upcase>. <upcase>We don't</upcase> have <upcase>anything</upcase> else.";

            Console.WriteLine(TextToUpper(text));
        }
        static StringBuilder TextToUpper(string text)
        {
            string[] separators = { "<upcase>", "</upcase>" };
            string[] array = text.Split(separators, StringSplitOptions.None);
            
            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = array[i].ToUpper();
            }

            StringBuilder result = new StringBuilder();
            foreach (string str in array)
            {
                result.Append(str);
            }
            return result;
        }
    }
}
