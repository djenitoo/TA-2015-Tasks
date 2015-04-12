using System;
// Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _05._HexToBinaryDirect
{
    class DirectHextToBin
    {
        static void HexToBinary(string hexNumber)
        {
            string binaryNumber = "";
            string[] binaryVal = 
            {
                "0000", "0001", "0010", "0011",
                "0100", "0101", "0110", "0111",
                "1000", "1001", "1010", "1011",
                "1100", "1101", "1110", "1111"
            };
            for (int i = 0; i < hexNumber.Length; i++)
            {
                if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
                {
                    binaryNumber += binaryVal[(int)hexNumber[i] - 48];
                }
                else if (hexNumber[i] == 'A')
                {
                    binaryNumber += binaryVal[10];
                }
                else if (hexNumber[i] == 'B')
                {
                    binaryNumber += binaryVal[11];
                }
                else if (hexNumber[i] == 'C')
                {
                    binaryNumber += binaryVal[12];
                }
                else if (hexNumber[i] == 'D')
                {
                    binaryNumber += binaryVal[13];
                }
                else if (hexNumber[i] == 'E')
                {
                    binaryNumber += binaryVal[14];
                }
                else if (hexNumber[i] == 'F')
                {
                    binaryNumber += binaryVal[15];
                }
            }
            Console.WriteLine(binaryNumber);
        }
        static void Main()
        {
            Console.Write("Enter a hex number: ");
            string hexNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");
            Console.Write("The binary representation of {0} is: ", hexNumber);
            HexToBinary(hexNumber);
            Console.WriteLine("-------------------------");
        }
    }
}
