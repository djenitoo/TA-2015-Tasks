using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

    Write a program to find the majorant of given array (if exists).
    Example:
        {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
*/
namespace _08.FindMajorantOfArray
{
    class FindMajorant
    {
        static int? FindOccurencesOfElements(List<int> list)
        {
            var currentMajorant = 0;
            var haveMajorant = false;
            var countedElements = new List<int>();
            int occurence;
            for (int i = 0; i < list.Count; i++)
            {
                if (countedElements.Contains(list[i]))
                {
                    continue;
                }

                occurence = list.FindAll(el => el.Equals(list[i])).Count;
                countedElements.Add(list[i]);

                if (occurence == currentMajorant)
                {
                    haveMajorant = false;
                }
                else if (occurence >= (list.Count)/2 + 1 && occurence > currentMajorant)
                {
                    haveMajorant = true;
                    currentMajorant = list[i];
                }
            }

            if (haveMajorant)
            {
                return currentMajorant;
            }

            return null;
        }

        static void Main(string[] args)
        {
            List<int> sequenceOfNumbers = new List<int>();
            //string input;
            //while ((input = Console.ReadLine()) != "")
            //{
            //    sequenceOfNumbers.Add(int.Parse(input));
            //}
            sequenceOfNumbers = new List<int> {2, 2, 3, 3, 2, 3, 4, 3, 3};
            Console.WriteLine("Your input: ");
            Console.WriteLine(string.Join(", ", sequenceOfNumbers));
            Console.WriteLine((FindOccurencesOfElements(sequenceOfNumbers) == null) ? "No majorant!" : FindOccurencesOfElements(sequenceOfNumbers) + " is the majorant!");
            
        }
    }
}
