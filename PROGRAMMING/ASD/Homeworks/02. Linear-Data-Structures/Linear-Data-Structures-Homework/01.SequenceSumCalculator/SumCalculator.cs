using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SequenceSumCalculator
{
    class SumCalculator
    {
        static void Main(string[] args)
        {
            int sumOfInputNumbers = 0;
            int inputNumbersCount = 0;
            int inputNumber = 0;
            string input;
            List<int> sequenceNumbers = new List<int>();

            Console.WriteLine("Enter numbers on separate line:");
            while (!string.IsNullOrEmpty((input = Console.ReadLine())))
            {
                inputNumber = int.Parse(input);
                inputNumbersCount++;
                sequenceNumbers.Add(inputNumber);
                sumOfInputNumbers += inputNumber;
            }
            Console.WriteLine("Entered sequence is: ");
            Console.WriteLine(string.Join(", ", sequenceNumbers));
            Console.WriteLine("Sum of the sequence numbers is: " + sumOfInputNumbers);
            Console.WriteLine("Average of input numbers is: " + (sumOfInputNumbers / inputNumbersCount));
        }
    }
}
