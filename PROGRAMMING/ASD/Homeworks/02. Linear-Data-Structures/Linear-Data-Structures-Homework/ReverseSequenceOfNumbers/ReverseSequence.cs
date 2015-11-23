namespace ReverseSequenceOfNumbers
{
    using System;
    using System.Collections.Generic;

    class ReverseSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter the count of number u will enter:");
            int numbersCount = int.Parse(Console.ReadLine());
            var sequenceNumbers = new Stack<int>();
            
            for (int i = 0; i < numbersCount; i++)
            {
                sequenceNumbers.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Reversed:");
            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write(sequenceNumbers.Pop() + " ");
            }

            //Console.WriteLine("Entered sequence:");
            //Console.WriteLine(string.Join(", ", sequenceNumbers));
            //Console.WriteLine("Reversed sequence using stack class:");
            //var reversed = sequenceNumbers.Reverse();
            //Console.WriteLine(string.Join(", ", reversed));
        }
    }
}
