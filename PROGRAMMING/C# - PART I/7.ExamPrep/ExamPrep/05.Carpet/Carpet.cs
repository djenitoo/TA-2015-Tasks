using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Carpet
{
    class Carpet
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int center = n / 2;
            int elementsOnLine = n;

            for (int i = 1; i <= n / 2; i++)
            {
                int elNum = 1;
                while (elNum <= elementsOnLine)
                {
                    if ((elNum <= center - i) || (elNum >= center + i))
                    {
                        Console.Write(".");
                        elNum++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("/");
                                elNum++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elNum++;
                            }
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                                elNum++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elNum++;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            for (int i = center; i > 0; i--)
            {
                int elNum = 1;
                while (elNum <= elementsOnLine)
                {
                    if ((elNum <= center - i) || (elNum >= center + i))
                    {
                        Console.Write(".");
                        elNum++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                                elNum++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elNum++;
                            }
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                                elNum++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elNum++;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
