using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Enigma_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] output = new string[input.Length];
            //BigInteger sum = new BigInteger();
            for (int i = 0; i < input.Length; i++)
            {
                BigInteger power = 1;
                BigInteger temp = 0;
                for (int j = input[i].Length - 1; j >= 0; j--)
                {
                    temp += ((BigInteger)(input[i][j] - 97)) * power;
                    power *= 17;
                }
                //sum += temp;
                string str = string.Empty;
                BigInteger number = temp;
                while (number > 0)
                {
                    BigInteger letter = number % 26;
                    number = number / 26;
                    str = (char)(letter + 97) + str;
                    
                }
                output[i] = str;
                //Console.Write(str + " ");
            }
            
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
