using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that removes from given sequence all numbers that occur odd number of times.

    Example:
        {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
*/
namespace _06.RemoveElementsWithOddTimeOccurence
{
    class RemoveElementsWithOddOcurence
    {
        static List<int> RemoveOddOccuringElements(List<int> list)
        {
            var validNumbers = new List<int>();
            var currOccurence = 0;
            int currNumber;
            for (int i = 0; i < list.Count; i++)
            {
                currNumber = list[i];
                if (validNumbers.Contains(currNumber))
                {
                    continue;
                }
                
                currOccurence = GetOccurenceCount(list, currNumber);
                
                if (currOccurence % 2 == 0)
                {
                    validNumbers.Add(currNumber);
                }
                else
                {
                    list.RemoveAll(el => el.Equals(currNumber));
                    i--;
                }
            }

            return list;
        }

        static int GetOccurenceCount(List<int> list, int element)
        {
            var listOfOccurences = list.FindAll(el => el.Equals(element));

            return listOfOccurences.Count;
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

            Console.WriteLine("Input without elements occuring odd times:");
            var sequenceWithoutOddTimesEls = RemoveOddOccuringElements(sequenceOfNumbers);
            Console.WriteLine(
                (sequenceWithoutOddTimesEls.Count == 0) ?
                "No positive elements!" :
                string.Join(", ", sequenceWithoutOddTimesEls)
                );
        }
    }
}
