using System;
//Declare two string variables and assign them with following value:
//    The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.


namespace _08.Exercise
{
    class Quatation
    {
        static void Main(string[] args)
        {
            string firstQ = "The \"use\" of quotations causes difficulties.";       // The first way using \"
            string secondQ = @"The ""use"" of quotations causes difficulties.";     // The second wat using @ and double ""
            Console.WriteLine(firstQ);          // Print out the first type of quotation
            Console.WriteLine(secondQ);         // Print out the second type of quotation
        }
    }
}
