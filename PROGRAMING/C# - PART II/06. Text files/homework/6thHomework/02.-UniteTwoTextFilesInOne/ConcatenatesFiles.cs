using System;
using System.IO;
// Write a program that concatenates two text files into another text file.

namespace _02._UniteTwoTextFilesInOne
{
    class ConcatenatesFiles
    {
        static void Main()
        {
            StreamReader text1 = new StreamReader("text1.txt"); // Not enough time for more exercise. :/
            StreamReader text2 = new StreamReader("text2.txt");
            StreamWriter concatenatedText = new StreamWriter("concText.txt");
                
            using (concatenatedText)
            {
                string line1, line2;
                while ((line1 = text1.ReadLine()) != null)
                {
                    concatenatedText.WriteLine(line1);
                }
                while ((line2 = text2.ReadLine()) != null)
                {
                    concatenatedText.WriteLine(line2);
                }
                
            }
            StreamReader text = new StreamReader("concText.txt");
            using (text)
            {
                string line;
                while ((line = text.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            
        }
    }
}
