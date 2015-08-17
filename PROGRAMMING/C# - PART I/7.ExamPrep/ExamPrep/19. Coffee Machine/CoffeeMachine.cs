using System;

class Program
{
    static void Main()
    {
        decimal N1 = decimal.Parse(Console.ReadLine());
        decimal N2 = decimal.Parse(Console.ReadLine());
        decimal N3 = decimal.Parse(Console.ReadLine());
        decimal N4 = decimal.Parse(Console.ReadLine());
        decimal N5 = decimal.Parse(Console.ReadLine());

        decimal money = (N1 * 0.05M) + (N2 * 0.10M) + (N3 * 0.20M) + (N4 * 0.50M) + (N5 * 1.00M);

        decimal amount = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        if (amount >= price)
	    {
		    decimal change = (amount - price);
            decimal leftMoney = (money - change);
            if (leftMoney < 0)
            {
                leftMoney = change - money;
                Console.WriteLine("No " + leftMoney);
            }
            else
            {
                Console.WriteLine("Yes " + leftMoney);
            }
            
	    }
        else
        {
            decimal neededMoney = price - amount;
            Console.WriteLine("More "+ neededMoney);
        }
        


    }
}

