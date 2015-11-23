using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortSequenceOfNumbers
{
    class SortingSequence
    {
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
            sequenceOfNumbers.Sort((x,y) => (x.CompareTo(y)));

            Console.WriteLine("Sorted:");
            Console.WriteLine(string.Join(", ", sequenceOfNumbers));
        }
    }
}
