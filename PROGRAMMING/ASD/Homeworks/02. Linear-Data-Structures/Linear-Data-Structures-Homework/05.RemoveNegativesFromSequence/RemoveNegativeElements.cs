using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that removes from given sequence all negative numbers.
namespace _05.RemoveNegativesFromSequence
{
    class RemoveNegativeElements
    {
        static List<int> RemoveNegativeElementsFromList(List<int> list)
        {
            var listWithNonNegativeElements = new List<int>();
            foreach (var number in list)
            {
                if (number < 0)
                {
                    continue;
                }
                listWithNonNegativeElements.Add(number);
            }

            return listWithNonNegativeElements;
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

            var sequenceWithPositiveElements = RemoveNegativeElementsFromList(sequenceOfNumbers);
            Console.WriteLine("The input without negative elements:");
            Console.WriteLine(
                (sequenceWithPositiveElements.Count == 0) ? 
                "No positive elements!" : 
                string.Join(", ", sequenceWithPositiveElements)
                );
        }
    }
}
