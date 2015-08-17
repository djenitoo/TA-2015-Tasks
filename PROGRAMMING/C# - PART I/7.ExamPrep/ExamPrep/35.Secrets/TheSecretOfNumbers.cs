using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Secrets
{
    class TheSecretOfNumbers
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long specialSum = 0;

            for (int i = number.Length - 1, j = 1; i >= 0; i--, j++)
            {
                if (i == 0 && (number[i] == '-'))
                {
                    break;
                }
                int digit = (int)number[i] - (int)('0');
                if (j % 2 == 0)
                {
                    specialSum += (digit * digit) * j; 
                }
                else
                {
                    specialSum += digit * (j * j);
                }
            }

            ulong alphaSeq = (ulong)specialSum % 10;
            if (alphaSeq == 0)
            {
                Console.WriteLine(specialSum);
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                string specSeq = "";
                for (ulong i = 0, j = (ulong)(specialSum % 26) + 1; i < alphaSeq; i++, j++)
                {
                    if (j > 26)
                    {
                        j = 1;
                    }
                    specSeq += (char)((j - 1) + (int)'A');
                }
                Console.WriteLine(specialSum);
                Console.WriteLine(specSeq);
            }
        }
    }
}
