using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.GameOfPage
{
    class GameOfPage
    {
        
        static void Main(string[] args)
        {

            string[] cookieTray = new string[16];
            string firstRow = string.Empty;
            string secondRow = string.Empty;
            string thirdRow = string.Empty;

            int rowX = 0;
            int colY = 0;
            string whatis = "";
            int upperRow = 0;
            int middleRow = 0;
            int downRow = 0;
            int firstCol = 0;
            int secondCol = 0;
            int thirdCol = 0;
            decimal money = 0M;

            for (int i = 0; i < 16; i++)
            {
                cookieTray[i] = Console.ReadLine();
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "paypal")
                {
                    break;
                }
                else {
                    rowX = int.Parse(Console.ReadLine());
                    colY = int.Parse(Console.ReadLine());
                }

                #region Check Positions
                // Check what is in the position
                
                if (cookieTray[rowX][colY] == '0')
                {
                    whatis = "smile";
                }
                else if (cookieTray[rowX][colY] == '1')
                {
                    #region Swith pattern
                    switch (rowX)
                    {
                        case 15:
                            upperRow = rowX - 2;
                            middleRow = rowX - 1;
                            downRow = rowX;
                            break;
                        case 0:
                            upperRow = rowX;
                            middleRow = rowX + 1;
                            downRow = rowX + 2;
                            break;
                        default:
                            upperRow = rowX - 1;
                            middleRow = rowX;
                            downRow = rowX + 1;
                            break;
                            
                    }
                    switch (colY)
                    {
                        case 15:
                            firstCol = colY - 2;
                            secondCol = colY - 1;
                            thirdCol = colY;
                            break;
                        case 0:
                            firstCol = colY;
                            secondCol = colY + 1;
                            thirdCol = colY + 2;
                            break;
                        default:
                            firstCol = colY - 1;
                            secondCol = colY;
                            thirdCol = colY + 1;
                            break;

                    }
                    #endregion

                    firstRow = cookieTray[upperRow][firstCol].ToString() + cookieTray[upperRow][secondCol].ToString() + cookieTray[upperRow][thirdCol].ToString();
                    secondRow = cookieTray[middleRow][firstCol].ToString() + cookieTray[middleRow][secondCol].ToString() + cookieTray[middleRow][thirdCol].ToString();
                    thirdRow = cookieTray[downRow][firstCol].ToString() + cookieTray[downRow][secondCol].ToString() + cookieTray[downRow][thirdCol].ToString();

                    if (firstRow == "111" && secondRow == "111" && thirdRow == "111")
                    {
                        if (rowX == middleRow && colY == secondCol)
                        {
                            whatis = "cookie";
                        }
                        else
                        {
                            whatis = "broken cookie";
                        }
                    }
                    else
                    {
                        whatis = "cookie crumb";
                    }
                }
                #endregion

                #region Commands
                //Check COMMANDS
                if (command == "what is")
                {
                    Console.WriteLine(whatis);
                }
                else if (command == "buy")
                {
                    if (whatis == "smile")
                    {
                        Console.WriteLine("smile");
                    }
                    else if (whatis != "cookie")
                    {
                        Console.WriteLine("page");
                    }
                    else
                    {
                        // buy it demek prevrashta gi v 0li
                        char[] arr = cookieTray[upperRow].ToCharArray();
                        arr[firstCol] = '0';
                        arr[secondCol] = '0';
                        arr[thirdCol] = '0';
                        cookieTray[upperRow] = arr.ToString();
                        arr = cookieTray[middleRow].ToCharArray();
                        arr[firstCol] = '0';
                        arr[secondCol] = '0';
                        arr[thirdCol] = '0';
                        cookieTray[middleRow] = arr.ToString();
                        arr = cookieTray[downRow].ToCharArray();
                        arr[firstCol] = '0';
                        arr[secondCol] = '0';
                        arr[thirdCol] = '0';
                        cookieTray[downRow] = arr.ToString();
                        money += 1.75M;
                    }
                }
                #endregion

            }
            Console.WriteLine(money);
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(cookieTray[i]);
            }
        }
    }
}
