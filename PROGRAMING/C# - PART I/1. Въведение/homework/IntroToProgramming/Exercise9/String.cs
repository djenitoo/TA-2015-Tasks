using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class String
    {
        static void Main(string[] args)
        {
            for (int i=2;i<=11;i++) 
            {
                Console.WriteLine(Math.Pow(-1,i)*i);
            }
        }
    }
}
