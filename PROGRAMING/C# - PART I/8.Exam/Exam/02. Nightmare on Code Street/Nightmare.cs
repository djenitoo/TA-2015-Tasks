using System;

namespace _02.Nightmare_on_Code_Street
{
    class Nightmare
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int sum = 0;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (((int)text[i] >= 48) && ((int)text[i] <= 57))
                {
                    if (i % 2 != 0)
                    {
                        int shift = 48;
                        sum = sum + ((int)text[i] - shift);
                        count++;
                    } 
                }
                
            }

            Console.WriteLine(count + " " + sum);
        }
    }
}
