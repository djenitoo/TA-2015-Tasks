using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ex_rugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            //int row = 0;

            int height = 2 * N + 1;
            int width = height;
            string write = "";
            int upXWidth = D / 2 + 1;
            int upXcount = upXWidth;

            for (int row = 1; row < height; row++)
            {   
                write = "";
                //from 0 to end ot D/2+1
                if (row <= upXWidth)
                {
                    
                    write = new string('#', upXcount);
                    if ((width - (2 * upXcount)) >= 3)
                    {
                        write += "\\" + new string('.', (width - (2 * upXcount)) - 2) + "/";
                    }

                    write += new string('#', upXcount);
                    upXcount += 1;
                    
                }


                //from D/2+2 to height/2 - 1




                // output lalallalalalala
                if (width - write.Length >= 2)
                {
                    write = new string('.', ((width - write.Length) - 2) / 2) + "\\" + write +"/" + new string('.', ((width - write.Length) - 2) / 2);
                }

                Console.WriteLine(write);
            }
        }
    }
}
