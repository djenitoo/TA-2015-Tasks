using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.

    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        2 → 2 times
        3 → 4 times
        4 → 3 times
*/
namespace _07.OccurenceCountOfElements
{
    class CountOccurencesOfElements
    {
        static int[] GetOccurenceOfElements(List<int> list)
        {
            var countOfOccurences = new int[10001];

            foreach (var number in list)
            {
                countOfOccurences[number] = list.FindAll(el => el.Equals(number)).Count;
            }

            return countOfOccurences;
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

            Console.WriteLine("Occurence of each element:");
            var occurenceList = GetOccurenceOfElements(sequenceOfNumbers);
            for (int i = 0; i < occurenceList.Length; i++)
            {
                if (occurenceList[i] != 0)
                {
                    Console.WriteLine(i + " -> " + occurenceList[i] + " times");
                }
            }
        }
    }
}
