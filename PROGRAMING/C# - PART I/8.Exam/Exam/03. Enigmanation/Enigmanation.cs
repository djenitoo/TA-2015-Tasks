using System;

namespace _03.Enigmanation
{
    class Enigmanation
    {
        static void Main()
        {
            double sum = 0;
            while (true)
            {
                string ch = Console.ReadLine();
                char cha = Convert.ToChar(ch);
                if (cha >= '1' && cha <= '9')
                {
                    int a = (int)(char)(cha - 48);
                }
                if (cha ==)
                {
                    
                }
                if (cha == '(')
                {
                    while (cha != ')')
                    {
                        if (cha >= '1' && cha <= '9')
                        {
                            int inner = (int)(char)(cha - 48);
                            if (cha == '%')
                            {
                                inner = inner % 2;
                            }
                        }
                    }
                }
            }
            
            
        }
    }
}
