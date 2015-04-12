using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main()
        {
            char[] lowerCaps = new char[7];
            char[] upperCaps = new char[26];
            List<int> numbers = new List<int>();
            lowerCaps[0] = (char)(0);

            for (int i = 1; i < 7; i++)
            {
                lowerCaps[i] = (char)(i + 96);
            }
            for (int i = 0; i < 26; i++)
            {
                upperCaps[i] = (char)(i + 65);
            }

            string input = Console.ReadLine();
            
            BigInteger result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 'a')
                {
                    int bigLetter = 0;
                    for (int p = 0; p < upperCaps.Length; p++)
                    {
                        if (input[i] == upperCaps[p])
                        {
                            bigLetter = p;
                            numbers.Add(bigLetter);
                            break;
                        }
                    }
                }

                if (input[i] > 'Z')
                {
                    int lilLetter = 0;
                    for (int j = 0; j < lowerCaps.Length; j++)
                    {
                        if (input[i] == lowerCaps[j])
                        {
                            lilLetter = j;
                            break;
                        }
                    }
                    int bigLetter = 0;
                    for (int p = 0; p < upperCaps.Length; p++)
                    {
                        if (input[i+1] == upperCaps[p])
                        {
                            bigLetter = p;
                            break;
                        }
                    }
                    bigLetter = (lilLetter * 26) + bigLetter;
                    numbers.Add(bigLetter);
                    i++;
                }
            }
            BigInteger power = 1;
            for (int item = numbers.Count - 1; item >= 0; item--)
            {
                result += numbers[item] * power;
                power *= 168;
            }
            Console.WriteLine(result);
        }
    }
}
