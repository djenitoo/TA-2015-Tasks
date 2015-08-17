using System;

namespace _01._2_4_8
{
    class SMSCode
    {
        static void Main()
        {
            ulong A = ulong.Parse(Console.ReadLine());
            ulong B = ulong.Parse(Console.ReadLine());
            ulong C = ulong.Parse(Console.ReadLine());

            ulong R = 0;
            ulong R1 = 0;
            if (B == 2)
            {
                R = A % C;
            }
            else if (B == 4)
            {
                R = A + C;
            }
            else if (B == 8)
            {
                R = A * C;
            }

            if (R % 4 == 0)
            {
                R1 = R / 4;
            }
            else
            {
                R1 = R % 4;
            }

            Console.WriteLine(R1);
            Console.WriteLine(R);
        }
    }
}
