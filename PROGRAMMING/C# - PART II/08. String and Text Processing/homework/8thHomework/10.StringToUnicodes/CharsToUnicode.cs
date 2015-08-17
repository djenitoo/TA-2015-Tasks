using System;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Use format strings. Sample input:
//      Hi!
//Expected output:
//      \u0048\u0069\u0021

namespace _10.StringToUnicodes
{
    class CharsToUnicode
    {
        static void Main(string[] args)
        {
            string p = "abcdfsdgdfg";           // I have totaly forgotten about format strings, and I gave up with searching apporitate unicode methods, so my source is http://pastebin.com/8JyLNkzr :)
            for (int i = 0; i < p.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)p[i]);
            }
            Console.WriteLine();
        }
    }
}
