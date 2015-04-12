using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.BullsAndCows
{
    class BullsAndCows
    {
        static void Main(string[] args)
        {
            int secterNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1000; i <= 9999; i++)
            {
                int currentBulls = 0;
                int currentCows = 0;
                int currentNumber = i;
                int secret = secterNumber;

                int currentD = currentNumber % 10;
                currentNumber /= 10;
                int currentC = currentNumber % 10;
                currentNumber /= 10;
                int currentB = currentNumber % 10;
                currentNumber /= 10;
                int currentA = currentNumber % 10;

                if (currentA == 0 || currentB == 0 || currentC == 0 || currentD == 0)
                {
                    continue;
                }

                int secretD = secret % 10;
                secret /= 10;
                int secretC = secret % 10;
                secret /= 10;
                int secretB = secret % 10;
                secret /= 10;
                int secretA = secret % 10;

                #region FindBulls
                if (currentA == secretA)
                {
                    currentBulls++;
                    currentA = -1;
                    secretA = -2;
                }
                if (currentB == secretB)
                {
                    currentBulls++;
                    currentB = -1;
                    secretB = -2;
                }
                if (currentC == secretC)
                {
                    currentBulls++;
                    currentC = -1;
                    secretC = -2;
                }
                if (currentD == secretD)
                {
                    currentBulls++;
                    currentD = -1;
                    secretD = -2;
                }
                #endregion

                #region Check Cows
                //A
                if (currentA == secretB)
                {
                    currentCows++;
                    secretB = -2;
                    currentA = -1;
                }
                if (currentA == secretC)
                {
                    currentCows++;
                    secretC = -2;
                    currentA = -1;
                }
                if (currentA == secretD)
                {
                    currentCows++;
                    secretD = -2;
                    currentA = -1;
                }


                //B
                if (currentB == secretA)
                {
                    currentCows++;
                    secretA = -2;
                    currentB = -1;
                }
                if ( currentB == secretC)
                {
                    currentCows++;
                    secretC = -2;
                    currentB = -1;
                }
                if ( currentB == secretD)
                {
                    currentCows++;
                    secretD = -2;
                    currentB = -1;
                }


                //C
                if ( currentC == secretA)
                {
                    currentCows++;
                    secretA = -2;
                    currentC = -1;
                }
                if ( currentC == secretB)
                {
                    currentCows++;
                    secretB = -2;
                    currentC = -1;
                }
                if (currentC == secretD)
                {
                    currentCows++;
                    secretD = -2;
                    currentC = -1;
                }


                //D
                if ( currentD == secretA)
                {
                    currentCows++;
                    secretA = -2;
                    currentD = -1;
                }
                if ( currentD == secretB)
                {
                    currentCows++;
                    secretB = -2;
                    currentD = -1;
                }
                if ( currentD == secretC)
                {
                    currentCows++;
                    secretC = -2;
                    currentD = -1;
                }
                #endregion


                if (currentBulls == bulls && currentCows == cows)
                {
                    result += " " + i;
                }
                
            }

            if (result.Length != 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
