﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LongSequence
{
    class LongSeqPrint
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                Console.WriteLine(Math.Pow(-1, i) * i);
            }
        }
    }
}
