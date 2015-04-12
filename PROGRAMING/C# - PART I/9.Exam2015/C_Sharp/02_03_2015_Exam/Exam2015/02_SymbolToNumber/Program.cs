using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SymbolToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int i = 0;

            while (text[i] != '@')
            {
                decimal charCode = 0;
                if (char.IsLetter(text[i]))
                {
                    charCode = ((decimal)(text[i]) * secret) + 1000;
                }
                else if (char.IsDigit(text[i]))
                {
                    charCode = (decimal)(text[i]) + secret + 500;
                }
                else
	            {
                    charCode = (decimal)(text[i]) - secret;
	            }

                if (i % 2 == 0)
                {
                    charCode = charCode / 100;
                    Console.WriteLine("{0:F2}", charCode);
                }
                else
                {
                    charCode *= 100;
                    Console.WriteLine(charCode);
                }
                i++;
            }
        }
    }
}
