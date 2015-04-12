using System;
//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console.

namespace _12.Exercise
{
    class CharTable
    {
        static void Main(string[] args)
        {
            for (int symbol = 0; symbol <= 127; symbol++)  // Declare the loop, symbol varies from 0 to 127 possition in ASCII Table
            {
                Console.WriteLine((char) symbol);          // Print out each symbol
            }
        }
    }
}
