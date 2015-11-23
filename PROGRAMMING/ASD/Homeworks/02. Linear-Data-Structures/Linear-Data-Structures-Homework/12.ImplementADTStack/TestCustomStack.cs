using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ImplementADTStack
{
    class TestCustomStack
    {
        static void Main(string[] args)
        {
            var customStack = new CustomStack<int>();
            for (int i = 0; i < 5; i++)
            {
                customStack.Push(i);
            }
            while(customStack.Count > 0)
            {
                Console.WriteLine(customStack.Pop());
            }
        }
    }
}
