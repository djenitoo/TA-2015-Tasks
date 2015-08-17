using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _14.CSharpBrackets
{
    class CSharpBrackets
    {
        static void Main()
        {
            //Console.BufferHeight = Int16.MaxValue - 1;
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            List<string> array = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string str = Console.ReadLine();
                if (str != "")
                {
                    str = Regex.Replace(str, @"(\s+)", " ");
                    //str = str.Trim();
                    array.Add(str);
                }
                
            }
            Method(array, N, S);
        }

        static void Method(List<string> array, int textRows, string tab)
        {
            int i = 0;
            int row = 0;
            int openBrackets = 0;
            int openBr = 0;
            StringBuilder line = new StringBuilder();
            while (row < array.Count)
            {
                if (array[row].Length > i && ((array[row][i] == '{') || (array[row][i] == '}')))
                {
                    if ((array[row][i] == '{'))
                    {
                        openBr++;
                        #region openbr == 1
                        if (openBr == 1)
                        {
                            for (int p = 0; p < openBrackets; p++)
                            {
                                line.Append(tab);
                            }
                            line.Append(array[row][i]);
                            Console.WriteLine(line);
                            line.Clear();
                            openBrackets++;
                        } 
                        #endregion
                        #region openbr++
                        else
                        {
                            for (int p = 0; p < openBrackets; p++)
                            {
                                line.Append(tab);
                            }
                            line.Append(array[row][i]);
                            Console.WriteLine(line);
                            line.Clear();
                            openBrackets++;

                        } 
                        #endregion
                    }
                    else if ((array[row][i] == '}'))
                    {
                        #region openbr--
                        openBrackets--;
                        for (int p = 0; p < openBrackets; p++)
                        {
                            line.Append(tab);
                        }
                        line.Append(array[row][i]);
                        Console.WriteLine(line);
                        line.Clear(); 
                        #endregion
                    }

                    if (i == array[row].Length - 1)
                    {
                        row++;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    int ind = 0;
                    while (array[row].Length > i && (array[row][i] != '{') && (array[row][i] != '}'))
                    {
                        
                        if (line.Length == 0)
                        {
                            for (int p = 0; p < openBrackets; p++)
                            {
                                line.Append(tab);
                            }
                            ind = line.Length;
                        }

                        line.Append(array[row][i]);
                        
                        if (line[ind] == ' ')
                        {
                            line.Remove(ind, 1);
                        }
                        if (((line.Length == 1)) && (array[row][i] == ' '))
                        {
                            line.Length--;
                        }
                        if (i == array[row].Length - 1)
                        {
                            if (row + 1 < textRows)
                            {
                                row++;
                            }
                            i = 0;
                            break;

                        }
                        else
                        {
                            i++;
                        }
                    }
                    if (line.ToString() != "" && line.Length > ind)
                    {
                        Console.WriteLine(line);
                    }
                    line.Clear();
                }
            }
        }
    }
}
