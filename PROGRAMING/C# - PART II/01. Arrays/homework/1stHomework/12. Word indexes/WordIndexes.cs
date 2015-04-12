using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.

namespace _12.Word_indexes
{
    class WordIndexes
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(i + 65);
            }

            Console.Write("Please, enter a word: ");
            string word = Console.ReadLine().ToUpper();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == word[i])
                    {
                        Console.Write(j + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
