using System;
//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

namespace _13.Exercise
{
    class NullUse
    {
        static void Main(string[] args)
        {
            int? integerNull = null;
            double? doubleNull = null;
            Console.WriteLine("The numbers values are {0} and {1} .",integerNull,doubleNull);

            integerNull += null;
            doubleNull += 40.05; // Not possible, stay null
            Console.WriteLine("The numbers values are {0} and {1} .", integerNull, doubleNull);

        }
    }
}
