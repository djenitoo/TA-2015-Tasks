using System;
using System.Data;

namespace _03.Enigmanation_2
{
    class enigmanation2
    {
        static void Main()
        {
            int sum = 0;
            
            string input = Console.ReadLine();

            int a = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 49 && input[i] <= 57)
                {
                    a = input[i] - 48;
                    continue;
                }
                if (input[i] == '+')
                {
                    sum += a;
                    continue;
                }
                if (input[i] == '-')
                {
                    sum -= a;
                    continue;
                }
                
                


            }
            Console.WriteLine(sum);
        }
    }
}
