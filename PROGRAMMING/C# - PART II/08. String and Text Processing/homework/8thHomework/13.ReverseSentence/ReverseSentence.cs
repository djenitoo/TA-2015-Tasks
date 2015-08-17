using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  
//           "Delphi not and PHP, not C++ not is C#!".

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        //static string ReverseWord(string text, int begin, int end)
        //{
        //    int i = begin;
        //    int j = end;
        //    StringBuilder str = new StringBuilder();
        //    str.Append(text);
        //    while (i <= (end - begin) / 2)
        //    {
        //        char temp = text[i];
        //        str[i] = text[j];
        //        str[j] = temp;
        //    }

        //    return text;
        //}
        static void Main()
        {
            //string text = "C# is not C++, not PHP and not Delphi!";
            //string[] separators = { ",", ":", ";"};
            //string[] arr = text.Split(separators, StringSplitOptions.None);
            //string[] sep = { " " };
            //int[] spaces = new int[arr.Length];
            //int[] indexesOfPunctoation = new int[arr.Length - 1];
            //for (int i = 0; i < spaces.Length; i++)
            //{
            //    spaces[i] = arr[i].Split(sep, StringSplitOptions.RemoveEmptyEntries).Length - 1;
            //}






























            //List<char> result = new List<char>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        if (!Char.IsLetter(arr[i][j]))
            //        {
            //            result.Add(' ');
            //            result.Add(arr[i][j]);
            //            result.Add(' ');
            //        }
            //        else
            //        {
            //            result.Add(arr[i][j]);
            //        }
            //    }
            //}
            //string strResult = string.Empty;
            //foreach (char ch in result)
            //{
            //    strResult += ch;
            //}
            //string[] lastSplitArr = strResult.Split(separators, StringSplitOptions.None);

            //string reversedSentence = string.Empty;

            //for (int i = lastSplitArr.Length - 1; i <= 0; i--)
            //{
            //    reversedSentence += lastSplitArr[i] + " ";
            //}
            //reversedSentence += lastSplitArr[lastSplitArr.Length - 1];
            //Console.WriteLine(reversedSentence);
        }
    }
}
