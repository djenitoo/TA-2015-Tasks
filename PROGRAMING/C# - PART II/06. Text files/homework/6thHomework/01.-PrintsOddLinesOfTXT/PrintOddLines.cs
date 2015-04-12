using System;
using System.IO;
// Write a program that reads a text file and prints on the console its odd lines.


namespace _01._PrintsOddLinesOfTXT
{
    class PrintOddLines
    {
        static void Main()
        {
            StreamReader text = new StreamReader("text.txt");

            using (text)
            {
                string line;
                int lineCount = 1;
                while ((line = text.ReadLine()) != null)
                {
                    if (lineCount % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineCount++;
                    
                }
            }
        }
    }
}
