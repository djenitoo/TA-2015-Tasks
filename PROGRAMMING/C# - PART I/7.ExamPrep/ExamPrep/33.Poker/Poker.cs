using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Poker
{
    class Poker
    {
        static void Main(string[] args)
        {
            int cA = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int c5 = 0;
            int c6 = 0;
            int c7 = 0;
            int c8 = 0;
            int c9 = 0;
            int c10 = 0;
            int cJ = 0;
            int cQ = 0;
            int cK = 0;
            for (int i = 0; i < 5; i++)
            {
                string card = Console.ReadLine();

                if (card == "A") { cA++; }
                if (card == "2") { c2++; }
                if (card == "3") { c3++; }
                if (card == "4") { c4++; }
                if (card == "5") { c5++; }
                if (card == "6") { c6++; }
                if (card == "7") { c7++; }
                if (card == "8") { c8++; }
                if (card == "9") { c9++; }
                if (card == "10") { c10++; }
                if (card == "J") { cJ++; }
                if (card == "Q") { cQ++; }
                if (card == "K") { cK++; }
            }

            //FiveOfKind
            bool fiveOfKind = false;
            if (cA == 5 || c2 == 5 || c3 == 5 || c4 == 5 || c5 == 5 || c6 == 5 || c7 == 5 || 
                c8 == 5 || c9 == 5 || c10 == 5 || cJ == 5 || cQ == 5 || cK == 5) { fiveOfKind = true; }

            // Four Of kind
            bool fourOfKind = false;
            if (cA == 4 || c2 == 4 || c3 == 4 || c4 == 4 || c5 == 4 || c6 == 4 || c7 == 4 || 
                c8 == 4 || c9 == 4 || c10 == 4 || cJ == 4 || cQ == 4 || cK == 4) { fourOfKind = true; }

            // tree of kind
            bool treeOfKind = false;
            if (cA == 3 || c2 == 3 || c3 == 3 || c4 == 3 || c5 == 3 || c6 == 3 || c7 == 3 || 
                c8 == 3 || c9 == 3 || c10 == 3 || cJ == 3 || cQ == 3 || cK == 3) { treeOfKind = true; }

            // two of kind
            int twoOfKind = 0;

            if (cA == 2) { twoOfKind++; }
            if (c2 == 2) { twoOfKind++; }
            if (c3 == 2) { twoOfKind++; }
            if (c4 == 2) { twoOfKind++; }
            if (c5 == 2) { twoOfKind++; }
            if (c6 == 2) { twoOfKind++; }
            if (c7 == 2) { twoOfKind++; }
            if (c8 == 2) { twoOfKind++; }
            if (c9 == 2) { twoOfKind++; }
            if (c10 == 2){ twoOfKind++; }
            if (cJ == 2) { twoOfKind++; }
            if (cQ == 2) { twoOfKind++; }
            if (cK == 2) { twoOfKind++; }

            // Consecutive 
            bool consecutive = false;
            if ((cA == 1 && c2 == 1 && c3 == 1 && c4 == 1 && c5 == 1) || (c2 == 1 && c3 == 1 && c4 == 1 && c5 == 1 && c6 == 1) ||
                (c3 == 1 && c4 == 1 && c5 == 1 && c6 == 1 && c7 == 1) || (c4 == 1 && c5 == 1 && c6 == 1 && c7 == 1 && c8 == 1) ||
                (c5 == 1 && c6 == 1 && c7 == 1 && c8 == 1 && c9 == 1) || (c6 == 1 && c7 == 1 && c8 == 1 && c9 == 1 && c10 == 1) ||
                (c7 == 1 && c8 == 1 && c9 == 1 && c10 == 1 && cJ == 1) || (c8 == 1 && c9 == 1 && c10 == 1 && cJ == 1) ||
                (c9 == 1 && c10 == 1 && cJ == 1 && cQ == 1 && cK == 1) || (c10 == 1 && cJ == 1 && cQ == 1 && cK == 1 && cA == 1))
            {
                consecutive = true;
            }

            if (fiveOfKind == true)
            {
                Console.WriteLine("Impossible");
            }
            else if (fourOfKind)
            {
                Console.WriteLine("Four of a Kind");
            }
            else if (treeOfKind && twoOfKind == 1)
            {
                Console.WriteLine("Full House");
            }
            else if (treeOfKind)
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (consecutive)
            {
                Console.WriteLine("Straight");
            }
            else if (twoOfKind == 2)
            {
                Console.WriteLine("Two Pairs");
            }
            else if (twoOfKind == 1)
            {
                Console.WriteLine("One Pair");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
