using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_aEx_rug
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            //int row = 0;
            if (N > 0 && D > 0)
            {
                int height = (2 * N) + 1;
                int width = height;
                string write = "";

                // most up
                #region Most Up
                int redove = D / 2;
                int upRedove = (height / 2) - (redove + 1);
                int to4ki = (upRedove - 1) * 2;
                if (height / 2 > redove + 1)
                {
                    for (int i = 1; i <= upRedove; i++)
                    {
                        write = "\\" + new string('.', 1 + to4ki) + "/";
                        to4ki -= 2;
                        int promenliva = D;
                        if (promenliva > (width - write.Length) / 2)
                        {
                            promenliva = (width - write.Length) / 2;
                        }
                        if (width - write.Length >= 2)
                        {
                            write = new string('#', promenliva) + write + new string('#', promenliva);
                        }
                        if (width - write.Length >= 2)
                        {
                            write = new string('.', ((width - write.Length) - 2) / 2) + "\\" + write + "/" + new string('.', ((width - write.Length) - 2) / 2);
                        }
                        Console.WriteLine(write);

                    }


                }
                #endregion

                // up X
                #region Up X
                int daljina = N;
                if (height / 2 - redove > 0)
                {
                    write = "X";

                    if (D <= daljina)
                    {
                        daljina = D;
                    }
                    write = new string('#', daljina) + write + new string('#', daljina);
                    if (width - write.Length >= 2)
                    {
                        write = new string('.', ((width - write.Length) - 2) / 2) + "\\" + write + "/" + new string('.', ((width - write.Length) - 2) / 2);
                    }
                }
                #endregion

                Console.WriteLine(write);

                // up
                #region Up
                int rowsCount = D / 2;
                if (height / 2 - D / 2 > 0 || D >= height)
                {
                    redove = D / 2;
                    if (redove >= height / 2)
                    {
                        redove = height / 2;
                    }
                    rowsCount = redove;
                    for (int i = 0; i < redove; i++)
                    {

                        int chastna = D + ((rowsCount - i) * 2);
                        if (chastna >= width)
                        {
                            chastna = width;
                        }
                        write = new string('#', chastna);

                        if (width - write.Length >= 2)
                        {
                            write = new string('.', ((width - write.Length) - 2) / 2) + "\\" + write + "/" + new string('.', ((width - write.Length) - 2) / 2);
                        }

                        Console.WriteLine(write);
                        //rowsCount -= 2;

                    }
                }
                #endregion

                // middle
                #region Middle
                write = new string('#', D);
                if (D >= width)
                {
                    write = new string('#', width);
                }
                if (width - write.Length >= 2)
                {
                    write = new string('.', ((width - write.Length) - 2) / 2) + "X" + write + "X" + new string('.', ((width - write.Length) - 2) / 2);
                }
                Console.WriteLine(write);

                #endregion

                // down
                #region Down
                rowsCount = D / 2;
                int broene = 2;
                if (height / 2 - D / 2 > 0 || D >= height)
                {
                    redove = D / 2;
                    if (redove >= height / 2)
                    {
                        redove = height / 2;
                    }
                    rowsCount = redove;
                    for (int i = 0; i < redove; i++)
                    {
                        int chastna = D + broene;
                        if (chastna >= width)
                        {
                            chastna = width;
                        }
                        write = new string('#', chastna);

                        if (width - write.Length >= 2)
                        {
                            write = new string('.', ((width - write.Length) - 2) / 2) + "/" + write + "\\" + new string('.', ((width - write.Length) - 2) / 2);
                        }

                        Console.WriteLine(write);
                        //rowsCount -= 2;
                        broene += 2;

                    }
                }
                #endregion

                // down X
                #region Down X
                if (height / 2 - redove > 0)
                {
                    write = "X";
                    daljina = N;
                    if (D <= daljina)
                    {
                        daljina = D;
                    }
                    write = new string('#', daljina) + write + new string('#', daljina);
                    if (width - write.Length >= 2)
                    {
                        write = new string('.', ((width - write.Length) - 2) / 2) + "/" + write + "\\" + new string('.', ((width - write.Length) - 2) / 2);
                    }

                    Console.WriteLine(write);
                }
                #endregion


                // most down

                #region Most down
                redove = D / 2;
                upRedove = (height / 2) - (redove + 1);
                //int to4ki = (upRedove - 1) * 2;
                to4ki = 0;
                if (height / 2 > redove + 1)
                {
                    for (int i = 1; i <= upRedove; i++)
                    {
                        write = "/" + new string('.', 1 + to4ki) + "\\";
                        to4ki += 2;

                        if (width - write.Length >= 2)
                        {
                            int promenliva = D;
                            if (promenliva > (width - write.Length) / 2)
                            {
                                promenliva = (width - write.Length) / 2;
                            }
                            write = new string('#', promenliva) + write + new string('#', promenliva);
                        }
                        if (width - write.Length >= 2)
                        {
                            write = new string('.', ((width - write.Length) - 2) / 2) + "/" + write + "\\" + new string('.', ((width - write.Length) - 2) / 2);
                        }
                        Console.WriteLine(write);

                    }
                }
                #endregion

                // out
                //Console.WriteLine(write);
            }
        }
    }
}
