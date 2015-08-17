namespace _02.BankAccounts
{
    using System;

    public class Program
    {
        static void Main()
        {
            var depositAcc = new DepositAccount(new Customer("Ivan Que", CustomerType.Individual), 100, 3.6M, new DateTime(2014, 01, 15));

            var loanAcc = new LoanAccount(new Customer("Peter P", CustomerType.Company), 1000M, 4.3M, new DateTime(2013, 07, 26));

            var mortgageAcc = new Mortgage(new Customer("Maria Deneris", CustomerType.Individual), 15000M, 7.5M, new DateTime(2012, 02, 16));

            //deposit acc test
            Console.WriteLine("Deposit account:");
            Console.WriteLine("Balance before deposit = " + depositAcc.Balance);
            depositAcc.Deposit = 1000M;
            Console.WriteLine("Balance after deposit = " + depositAcc.Balance);

            Console.WriteLine("Balance before withdraw = " + depositAcc.Balance);
            depositAcc.WitdrawAmount = 500M;
            Console.WriteLine("Balance after withdraw = " + depositAcc.Balance);

            Console.WriteLine("Calculate interest rate for 9 months = " + depositAcc.CalculateInterestAmount(9));
            
            // loan test
            Console.WriteLine("\r\nLoan account:");
            Console.WriteLine("Balance before deposit = " + loanAcc.Balance);
            loanAcc.Deposit = 330M;
            Console.WriteLine("Balance after deposit = " + loanAcc.Balance);

            Console.WriteLine("Calculate interest rate for 9 months = " + loanAcc.CalculateInterestAmount(6));

            // mortgage test
            Console.WriteLine("\r\nMortgage account:");
            Console.WriteLine("Balance before deposit = " + mortgageAcc.Balance);
            mortgageAcc.Deposit = 8033M;
            Console.WriteLine("Balance after deposit = " + mortgageAcc.Balance);

            Console.WriteLine("Calculate interest rate for 9 months = " + mortgageAcc.CalculateInterestAmount(10));

        }
    }
}
