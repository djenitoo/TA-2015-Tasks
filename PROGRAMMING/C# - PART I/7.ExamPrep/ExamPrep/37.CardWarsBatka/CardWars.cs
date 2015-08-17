using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _37.CardWarsBatka
{
    class CardWars
    {
        static void Main(string[] args)
        {
            BigInteger firstPlayerScore = 0;
            BigInteger secondPlayerScore = 0;
            int wonByOne = 0;
            int wonByTwo = 0;
            int N = int.Parse(Console.ReadLine());
            bool drawnX = false;

            for (int i = 0; i < N; i++)
            {
                int handOne = 0;
                int handTwo = 0;
                string[] cardsOne = new string[3];
                cardsOne[0] = Console.ReadLine();
                cardsOne[1] = Console.ReadLine();
                cardsOne[2] = Console.ReadLine();

                string[] cardsTwo = new string[3];
                cardsTwo[0]= Console.ReadLine();
                cardsTwo[1]= Console.ReadLine();
                cardsTwo[2]= Console.ReadLine();

                bool cXFirstPlayer = false;
                bool cXSecondPlayer = false;

                for (int j = 0; j < 3; j++)
                {
                    #region HandOne
                    if (cardsOne[j] == "A")
                    {
                        handOne += 1;
                    }
                    else if (cardsOne[j] == "Z")
                    {
                        firstPlayerScore *= 2;
                    }
                    else if (cardsOne[j] == "Y")
                    {
                        firstPlayerScore -= 200;
                    }
                    else if (cardsOne[j] == "X")
                    {
                        cXFirstPlayer = true;
                    }
                    else if (cardsOne[j] == "2")
                    {
                        handOne += 10;
                    }
                    else if (cardsOne[j] == "3")
                    {
                        handOne += 9;
                    }
                    else if (cardsOne[j] == "4")
                    {
                        handOne += 8;
                    }
                    else if (cardsOne[j] == "5")
                    {
                        handOne += 7;
                    }
                    else if (cardsOne[j] == "6")
                    {
                        handOne += 6;
                    }
                    else if (cardsOne[j] == "7")
                    {
                        handOne += 5;
                    }
                    else if (cardsOne[j] == "8")
                    {
                        handOne += 4;
                    }
                    else if (cardsOne[j] == "9")
                    {
                        handOne += 3;
                    }
                    else if (cardsOne[j] == "10")
                    {
                        handOne += 2;
                    }
                    else if (cardsOne[j] == "J")
                    {
                        handOne += 11;
                    }
                    else if (cardsOne[j] == "Q")
                    {
                        handOne += 12;
                    }
                    else
                    {
                        handOne += 13;
                    }
                    #endregion

                    #region HandTwo
                    if (cardsTwo[j] == "A")
                    {
                        handTwo += 1;
                    }
                    else if (cardsTwo[j] == "Z")
                    {
                        secondPlayerScore *= 2;
                    }
                    else if (cardsTwo[j] == "Y")
                    {
                        secondPlayerScore -= 200;
                    }
                    else if (cardsTwo[j] == "X")
                    {
                        cXSecondPlayer = true;
                    }
                    else if (cardsTwo[j] == "2")
                    {
                        handTwo += 10;
                    }
                    else if (cardsTwo[j] == "3")
                    {
                        handTwo += 9;
                    }
                    else if (cardsTwo[j] == "4")
                    {
                        handTwo += 8;
                    }
                    else if (cardsTwo[j] == "5")
                    {
                        handTwo += 7;
                    }
                    else if (cardsTwo[j] == "6")
                    {
                        handTwo += 6;
                    }
                    else if (cardsTwo[j] == "7")
                    {
                        handTwo += 5;
                    }
                    else if (cardsTwo[j] == "8")
                    {
                        handTwo += 4;
                    }
                    else if (cardsTwo[j] == "9")
                    {
                        handTwo += 3;
                    }
                    else if (cardsTwo[j] == "10")
                    {
                        handTwo += 2;
                    }
                    else if (cardsTwo[j] == "J")
                    {
                        handTwo += 11;
                    }
                    else if (cardsTwo[j] == "Q")
                    {
                        handTwo += 12;
                    }
                    else
                    {
                        handTwo += 13;
                    }
                    #endregion
                }

                

                if (cXFirstPlayer && cXSecondPlayer)
                {
                    firstPlayerScore += 50;
                    secondPlayerScore += 50;

                }
                else if (cXFirstPlayer)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    drawnX = true;
                    break;
                }
                else if (cXSecondPlayer)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    drawnX = true;
                    break;
                }

                if (handOne > handTwo)
                {
                    firstPlayerScore += handOne;
                    wonByOne++;
                }
                else if (handTwo > handOne)
                {
                    secondPlayerScore += handTwo;
                    wonByTwo++;
                }
                else if (handOne == handTwo)
                {
                    continue;
                }
            }

            if (!drawnX)
            {
                if (firstPlayerScore > secondPlayerScore)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: " + firstPlayerScore);
                    Console.WriteLine("Games won: " + wonByOne);
                }
                else if (firstPlayerScore < secondPlayerScore)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: " + secondPlayerScore);
                    Console.WriteLine("Games won: " + wonByTwo);
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: " + secondPlayerScore);
                }
            }
        }
    }
}
