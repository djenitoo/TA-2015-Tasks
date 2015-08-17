using System;
// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace _08._BinaryReprOfByte
{
    class BinRepresOfShort
    {
        static string BinaryOfShort(short number)
        {
            char[] binary = new char[16];
            byte positon = 15;
            byte index = 0;
            while (index < 16)
            {
                if ((number & (1<<index)) != 0)
                {
                    binary[positon] = '1';
                    index++;
                    positon--;
                }
                else
                {
                    binary[positon] = '0';
                    index++;
                    positon--;
                }
            }
            return new string(binary).TrimStart('0');
        }
        static void Main()
        {
            Console.Write("Enter a (short)number: ");
            short number = short.Parse(Console.ReadLine());

            Console.Write("The binary representation: ");
            Console.WriteLine(BinaryOfShort(number));
        }
    }
}
