using System;

namespace _10.A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] {" ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", 
                "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            char firstNumb = char.Parse(Console.ReadLine());
            char secondNumb = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            int indexOne = 0;
            int indexTwo = 0;

            for (int i = 1; i <= 26; i++)
            {
                if (firstNumb == (Convert.ToChar(array[i])))
                {
                    indexOne = i;
                }
                if (secondNumb == Convert.ToChar(array[i]))
                {
                    indexTwo = i;
                }
            }
            string[] secondArr = new string[2 * lines - 1];
            secondArr[0] = array[indexOne];
            secondArr[1] = array[indexTwo];
            int one = indexOne;
            int two = indexTwo;
            if (true)
            {
                for (int i = 1; i < (lines * 2) - 1; i++)
                {
                    int variable = one + two;
                    one = two;
                    two = variable;
                    int variableSec = 0;
                    if (variable > 26)
                    {
                        while (variable > 26)
                        {
                            variableSec = variable % 26;
                            variable = variableSec;
                        }
                    }
                    secondArr[i] = array[variable];
                }
                int briqch = 0;
                int space = 1;
                for (long i = 1; i <= lines; i++)
                { 
                    long elOnRow = 1;
                    while (elOnRow <= i)
                    {
                        if (i < 3)
                        {
                            Console.Write(secondArr[briqch]);
                            briqch++;
                            elOnRow++;
                        }
                        else
                        {
                            Console.Write(secondArr[briqch]);
                            briqch++;
                            elOnRow++;
                            Console.Write(new string(' ', space));
                            space++;
                            elOnRow += space;
                            Console.Write(secondArr[briqch]);
                            briqch++;
                            elOnRow++;
                        }
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
