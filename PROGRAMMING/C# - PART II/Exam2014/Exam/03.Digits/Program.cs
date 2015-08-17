using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.DurKulNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphabetLowCase = alphabet.ToLower();

            List<string> duranAlphabet = new List<string>();

            for (int i = 0; i < alphabet.Length; i++)
            {
                duranAlphabet.Add(alphabet[i].ToString());
            }
            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        duranAlphabet.Add(alphabetLowCase[i].ToString() + alphabet[j].ToString());

                    }
                }
                else
                {
                    for (int k = 0; k < 12; k++)
                    {
                        duranAlphabet.Add(alphabetLowCase[i].ToString() + alphabet[k].ToString());
                    }
                }

            }

            string duranNumber = Console.ReadLine();
            List<ulong> result = new List<ulong>();
            string temp;
            int index = 0;
            int breakingBad = 0;
            while (index < duranNumber.Length)
            {
                if (duranAlphabet.Contains(duranNumber))
                {
                    //Console.WriteLine(i);
                    result.Add((ulong)duranAlphabet.IndexOf(duranNumber));
                    break;

                }
                else
                {
                    //index = 0;
                    if ((char.IsLower(duranNumber[index])))
                    {

                        temp = duranNumber[index].ToString() + duranNumber[index + 1].ToString();
                        
                        result.Add((ulong)duranAlphabet.IndexOf(temp));
                        //for (int m = 0; m < duranAlphabet.Count; m++)
                        //{
                        //    if (temp == duranAlphabet[m])
                        //    {
                        //        result.Add((ulong)m);
                        //        break;
                        //    }
                        //}
                        index+= 2;
                    }
                    else 
                    {
                        result.Add(  (ulong)duranAlphabet.IndexOf(  duranNumber[index].ToString() )   );
                        index++;
                        //while (breakingBad != 1 && index < duranNumber.Length)
                        //{
                        //    for (int m = 0; m < duranAlphabet.Count; m++)
                        //    {
                        //        temp = duranNumber[index].ToString();
                        //        if (temp == duranAlphabet[m])
                        //        {
                        //            result.Add((ulong)m);
                        //            breakingBad = 1;
                        //            index++;
                        //            break;
                        //        }
                        //    }

                        //}

                    }
                }
            }

            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            result.Reverse();
            BigInteger final = result[0];
            //ulong pow = 1;
            for (int i = 1; i < result.Count; i++)
            {
                //pow = pow * 168;
                final += result[i] * (BigInteger)Math.Pow(168, i);

            }
            Console.WriteLine(final);
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _03.Digits
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {



//            int N = int.Parse(Console.ReadLine());
//            var matrix = new string[N];
//            for (int i = 0; i < N; i++)
//            {
//                var line = new StringBuilder();
//                line.AppendFormat(Console.ReadLine());
//                line.Replace(" ", "");
//                matrix[i] = line.ToString();
//            }
//            MatrixOfDigits();
//            for (int i = 0; i < matrix.Length - 5; i++)
//            {
//                for (int j = 0; j < matrix[i].Length - 3; j++)
//                {
                    
//                }
//            }
//        }

//        private static void MatrixOfDigits()
//        {
//             var digits = new List<string[]>();
//             digits.Add(new string[]{ "000", "0 0", "0 0", "0 0", "000" });
//             digits.Add(new string[]{ "  1", " 11", "1 1", "  1", "  1" });
//             digits.Add(new string[]{ " 2 ", "2 2", "  2", " 2 ", "222" });
//             digits.Add(new string[]{ "333", "  3", " 33", "  3", "333" });
//             digits.Add(new string[]{ "4 4", "4 4", "444", "  4", "  4" });
//             digits.Add(new string[]{ "555", "5  ", "555", "  5", "555" });
//             digits.Add(new string[]{ "666", "6  ", "666", "6 6", "666" });
//             digits.Add(new string[]{ "777", "  7", " 7 ", " 7 ", " 7 " });
//             digits.Add(new string[]{ "888", "8 8", " 8 ", "8 8", "888" });
//             digits.Add(new string[] { "999", "9 9", " 99", "  9", "999" });
//        }
//    }
//}
