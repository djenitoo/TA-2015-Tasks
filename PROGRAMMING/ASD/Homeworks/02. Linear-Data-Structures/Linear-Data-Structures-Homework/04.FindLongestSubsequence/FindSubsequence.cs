using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindLongestSubsequence
{
    class FindSubsequence
    {
        static List<int> FindBiggestSubsequenceOfEqualNumbers(List<int> list)
        {
            //if (list.Count < 2)
            //{
            //    return new List<int>();
            //}

            int maxSubSequenceLen = 0;
            int maxSubSequenceBegin = 0;
            int currentSubSequenceLen = 1;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1].Equals(list[i]))
                {
                    currentSubSequenceLen++;
                }
                else
                {
                    if (currentSubSequenceLen > maxSubSequenceLen)
                    {
                        maxSubSequenceLen = currentSubSequenceLen;
                        maxSubSequenceBegin = i - currentSubSequenceLen + 1;
                        currentSubSequenceLen = 1;
                    }
                }
            }

            if (currentSubSequenceLen > maxSubSequenceLen)
            {
                maxSubSequenceLen = currentSubSequenceLen;
                maxSubSequenceBegin = (list.Count-1) - currentSubSequenceLen + 1;
            }
            if (maxSubSequenceLen == 1 && list.Count == 2)
            {
                return new List<int>();
            }

            return new List<int>(list.GetRange(maxSubSequenceBegin, maxSubSequenceLen));

        } 

        static void Main(string[] args)
        {
            List<int> sequenceOfNumbers = new List<int>();
            string input;
            while ((input = Console.ReadLine()) != "")
            {
                sequenceOfNumbers.Add(int.Parse(input));
            }
            Console.WriteLine("Your input: ");
            Console.WriteLine(string.Join(", ", sequenceOfNumbers));

            var maxSequence = FindBiggestSubsequenceOfEqualNumbers(sequenceOfNumbers);

            if (maxSequence.Count < 1)
            {
                Console.WriteLine("There is no max sequence of equal numbers!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", maxSequence));
            }


        }
    }
}
