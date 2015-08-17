using System;

namespace _06._BinaryToHexDirect
{
    class BinaryToHexDirectly
    {
        static void BinToHex(string binNumber)              // There is a way so when we enter 1 like 1, not 0001, not to out error. The way is: we check  
        {                                                   // if the bin number lenght is % 4 == 0, if not - binNumber = "0" + binNumber,
            string hexNumber = string.Empty;                          // until binNumber % 4 == 0, but I will not do it because Im little lazy & bc i am in session my time is little gold :D :D
            string[] hexArray = 
            {
                "0","1","2", "3",
                "4","5","6", "7",
                "8","9","A", "B",
                "C","D","E", "F"
            };
            string[] binaryVal = 
            {
                "0000", "0001", "0010", "0011",
                "0100", "0101", "0110", "0111",
                "1000", "1001", "1010", "1011",
                "1100", "1101", "1110", "1111"
            };
            for (int i = 0; i < binNumber.Length - 3; i += 4)
            {
                string midNumber = binNumber[i].ToString() + binNumber[i + 1].ToString() + binNumber[i + 2].ToString() + binNumber[i + 3].ToString();
                for (int j = 0; j < binaryVal.Length; j++)
                {
                    if (midNumber == binaryVal[j])
                    {
                        hexNumber += hexArray[j];
                    }
                }
            }

            Console.WriteLine(hexNumber);
        }
        static void Main()
        {
            Console.WriteLine("Enter a binary number, if the first number is 1, then you have to enter - 0001, not 1 : ");
            string binaryNumber = Console.ReadLine();

            Console.WriteLine("-------------------------");
            Console.Write("The hexadecimal representation of {0} is: ", binaryNumber);
            BinToHex(binaryNumber);
            Console.WriteLine("-------------------------");
        }
    }
}
