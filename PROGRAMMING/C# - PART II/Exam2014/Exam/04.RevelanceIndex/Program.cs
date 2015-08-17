using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.RevelanceIndex
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            string newWord = string.Empty;
            List<StringBuilder> arr = new List<StringBuilder>();
            List<int> counts = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                newWord += Char.ToUpper(word[i]);
            }
            for (int i = 0; i < rows; i++)
            {
                StringBuilder input = new StringBuilder();
                string inp = Console.ReadLine();
                inp = Regex.Replace(inp, @"[,]", " ");
                inp = Regex.Replace(inp, @"[.]", " ");
                inp = Regex.Replace(inp, @"[,]", " ");
                inp = Regex.Replace(inp, @"[!]", " ");
                inp = Regex.Replace(inp, @"[(]", " ");
                inp = Regex.Replace(inp, @"[)]", " ");
                inp = Regex.Replace(inp, @"[!]", " ");
                inp = Regex.Replace(inp, @"[?]", " ");
                int count = 0;
                string[] splStr = inp.Split(' ');
                inp = "";
                for (int d = 0; d < splStr.Length; d++)
                {
                    if (splStr[d] != " " && splStr[d] != "")
                    {
                        if (splStr[d].ToUpper() == newWord)
                        {
                            count++;
                            splStr[d] = newWord;
                        }
                        inp += splStr[d] + " ";
                    }
                    
                }
                input.Append(inp);
                //int count = Regex.Matches(inp, word).Count;
                //input = input.Replace(word + " ", newWord + " ");
                //input = input.Replace(" " + word + " ", " " + newWord + " ");
                //input = input.Replace(" " + word, " " + newWord);
                //input = Regex.Replace(input, @"[,]", " ");
                counts.Add(count);
                counts.Sort();
                if (i != 0)
                {
                    int p = counts.BinarySearch(count);
                    if (p >= 0)
                    {
                        //if (p < arr.Count)
                        //{
                            arr.Insert(p, input);
                        //}
                        
                    }
                    else if (p < 0)
                    {
                        if (count > counts[counts.Count - 1])
                        {
                            arr.Add(input);
                        }
                        else
                        {
                            bool find = false;
                            int temp = count;
                            while (temp >= 0)
                            {
                                int q = counts.BinarySearch(temp);
                                if (q < 0)
                                {
                                    temp--;
                                }
                                else
                                {
                                    find = true;
                                    arr.Insert(q + 1, input);
                                    break;
                                }
                            }
                            if (!find)
                            {
                                temp = count;
                                while (temp <= counts[counts.Count - 1])
                                {
                                    int q = counts.BinarySearch(temp);
                                    if (q < 0)
                                    {
                                        temp++;
                                    }
                                    else
                                    {
                                        //find = true;
                                        arr.Insert(q - 1, input);
                                        break;
                                    }
                                }
                            }
                        }
                        
                    }
                    //arr.Insert(p, input);
                }
                else
                {
                    arr.Add(input);
                }

            }
            arr.Reverse();
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);

            }

        }

    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Text.RegularExpressions;

//namespace _04.RevelanceIndex
//{
//    class Program
//    {
//        static void Main()
//        {
//            string word = Console.ReadLine();
//            int rows = int.Parse(Console.ReadLine());
//            string newWord = word.ToUpper();
//            List<string> arr = new List<String>();
//            List<int> counts = new List<int>();
//            //for (int i = 0; i < word.Length; i++)
//            //{
//            //    newWord += Char.ToUpper(word[i]);
//            //}
//            Console.WriteLine( word + " " + newWord);
//            for (int i = 0; i < rows; i++)
//            {
                
//                string input = Console.ReadLine();
                
//                int count = Regex.Matches(input, word).Count; 
//                input = input.Replace(word + " ", newWord + " ");
//                input = input.Replace(" " + word + " ", " " + newWord + " ");
//                input = input.Replace(" " + word, " " + newWord);
//                input = Regex.Replace(input, @"(\s+)", " ");
//                input = Regex.Replace(input, @"[.]", "");
//                input = Regex.Replace(input, @"[,]", "");
//                input = Regex.Replace(input, @"[!]", "");
//                input = Regex.Replace(input, @"[(]", "");
//                input = Regex.Replace(input, @"[)]", "");
//                input = Regex.Replace(input, @"[!]", "");
//                input = Regex.Replace(input, @"[?]", "");
                
//                //
//                counts.Sort();
//                counts.Add(count);
//                if (i != 0)
//                {
//                    int p = counts.BinarySearch(count);
//                    if (p >= 0)
//                    {
//                        arr.Insert(p, input);
//                    }
//                    else
//                    {
                        
//                    }
                    
//                }
//                else
//                {
//                    arr.Add(input);
//                }
                
//                //arr.Add(input);
//            }
//            arr.Reverse();
//            for (int i = 0; i < arr.Count; i++)
//            {
//                //int p = counts.Max();
//                //int d = Search(counts, p);
//                //if (d >= 0)
//                //{
//                    Console.WriteLine(arr[i]);
//                //}
//                //counts[d] = -1;
//            }

//        }
//        //static int Search(List<int> array, int p)
//        //{
//        //    int index = 0;
//        //    for (int i = 0; i < array.Count; i++)
//        //    {
//        //        if (array[i] == p)
//        //        {
//        //            index = i;
//        //            array[i] = -1;
//        //            break;
//        //        }
                
//        //    }
//        //    return index;
//        //}
//    }
//}
