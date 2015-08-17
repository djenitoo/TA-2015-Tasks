using System;
using System.IO;
// Write a program that reads a text file and inserts line numbers in front of each of its lines. 
// The result should be written to another text file.

namespace _03._InsertLineNumbers
{
    class InsertLines
    {
        static void Main()
        {
            StreamReader text = new StreamReader("text.txt");
            StreamWriter text2 = new StreamWriter("text.txt");
            using (text2)
            {
                string line;
                int lineNumb = 1;
                while ((line = text.ReadLine()) != null)
                {
                    text2.WriteLine("{0} {1}", lineNumb, line);
                    lineNumb++;
                }
            }

            StreamWriter finalText = new StreamWriter("finalText.txt");

            using (finalText)
            {
                string line;
                while ((line = text.ReadLine()) != null)
                {
                    finalText.WriteLine(line);
                }
            }
            StreamReader final = new StreamReader("finalText.txt");
            using (final)
            {
                string line;
                while ((line = finalText.ReadLine()) != null)
                {
                    finalText.WriteLine(line);
                }
            }
        }
    }
}
