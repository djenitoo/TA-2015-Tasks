using System;
//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

namespace _09.Exercise
{
    class Triangle
    {
        static void Main(string[] args)
        {
            char copyC ='\u00A9'; // Declaration of the unicode
            Console.WriteLine(new String(' ', 3) + copyC);
            Console.WriteLine(new String(' ', 2) + copyC + " " + copyC);
            Console.WriteLine(" " + copyC + new String(' ', 3) + copyC);                // Triangle building
            Console.WriteLine(copyC + " " + copyC + " " + copyC + " " + copyC);
            Console.WriteLine();

        }
    }
}
