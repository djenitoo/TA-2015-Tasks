using System;
//Declare a character variable and assign it with the symbol that has Unicode code 42. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 42.

namespace _05.Exercise
{
    class CharSymbol
    {
        static void Main(string[] args)
        {
            // With Windows Calc we find that 42 in decimal is 2A in hex, then:

            char symbol = '\u002A';                      // Declare the variable
            Console.WriteLine(symbol);        // Print the variable
        }
    }
}
