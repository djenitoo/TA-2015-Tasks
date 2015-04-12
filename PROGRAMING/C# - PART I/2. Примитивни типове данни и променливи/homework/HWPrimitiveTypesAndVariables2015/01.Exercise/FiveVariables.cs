using System;
//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.


namespace _01.Exercise
{
    class FiveVariables
    {
        static void Main(string[] args)
        {
            sbyte a = -115; //because the number is between -128 and 127
            byte b = 97; //because the number is positive and b/w 0 and 255
            short c = -10000; // because the number is between -32768 and 32767
            ushort d = 52130; // because the number is in the range 0 and 65535
            uint e = 4825932; // because the number is positive and is in the range 0 4294967295

            Console.WriteLine("sbyte -> {0} \n byte -> {1} \n short -> {2} \n ushort -> {3} \n uint -> {4}", a,b,c,d,e); // Print the numbers and theirs types
        }
    }
}
