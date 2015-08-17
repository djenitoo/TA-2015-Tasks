using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = new List<BigInteger>();
            
            string input = Console.ReadLine();

            while (input != "END")
            {
                numbers.Add(Convert.ToUInt64(input));
                input = Console.ReadLine();
            }

            int lastIndex = numbers.Count;
            if (numbers.Count <= 10)
            {
                lastIndex = numbers.Count;
            }
            else
            {
                lastIndex = 10;
            }
            
            BigInteger[] productOf10 = {1,1,1,1,1};
            List<BigInteger> products = new List<BigInteger>();

            #region Product Of Ten
            for (int i = 0, j = 0; i < numbers.Count; i++)
			{
                if (i < lastIndex)
                {
                    if (i % 2 == 0)
                    {
                        if (numbers[i] == 0)
                        {
                            productOf10[j] = 1;
                        }
                        else
                        {
                            BigInteger tempProduct = 1;
                            BigInteger tempNumber = numbers[i];

                            while (tempNumber != 0)
                            {
                                if (tempNumber % 10 != 0)
                                {
                                    tempProduct *= tempNumber % 10;
                                }
                                tempNumber /= 10;
                            }
                            productOf10[j] = tempProduct;
                        }
                        j += 1;
                    }
                }

                if (i >= 10)
                {
                    if (i % 2 == 0)
                    {
                        if (numbers[i] == 0)
                        {
                            products.Add(1);
                        }
                        else
                        {
                            BigInteger tempProduct = 1;
                            BigInteger tempNumber = numbers[i];

                            while (tempNumber != 0)
                            {
                                if (tempNumber % 10 != 0)
                                {
                                    tempProduct *= tempNumber % 10;
                                }
                                tempNumber /= 10;
                            }
                            products.Add(tempProduct);
                        }
                    }
                }
			}
            BigInteger proOf10 = 1;
            for (int i = 0; i < productOf10.Length; i++)
            {
                proOf10 *= productOf10[i];
            }

            Console.WriteLine(proOf10);
            #endregion

            BigInteger secProduct = 1;
            if (numbers.Count > 10)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    secProduct *= products[i];
                }
                Console.WriteLine(secProduct);
            }

            
        }
    }
}
