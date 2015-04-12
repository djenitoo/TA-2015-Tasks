using System;

namespace _15.Astrological_Digits
{
    class AstroDigits
    {
        static void Main()
        {
            ulong sumOfDigits = 0;
            while (true)
            {
                int ch = Console.Read();
                if (ch == '\n' || ch == '\r' || ch == -1)
                {
                    break;
                }
                if (ch >= '0' && ch <= '9')
                {
                    ulong digit = (ulong)ch - (ulong)'0';
                    sumOfDigits = sumOfDigits + digit;
                }
            }
            while (sumOfDigits > 9)
            {
                ulong nextSum = 0;
                while (sumOfDigits > 0)
                {
                    ulong digits = sumOfDigits % 10;
                    sumOfDigits = sumOfDigits / 10;
                    nextSum = nextSum + digits;
                }
                sumOfDigits = nextSum;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
