namespace _02.BankAccounts
{
    using System;

    public class DepositAccount : Account, IDepositable, IWhitdrawable
    {
        private int p1;
        private double p2;
        private DateTime dateTime;

        public DepositAccount(Customer customer, decimal strartBalance, decimal interestRate, DateTime date)
            : base(customer, strartBalance, interestRate, date)
        {
        }

        public decimal Deposit
        {
            set 
            {
                if (value < 10)  // let say the least you can deposit is 10$ or lv
                {
                    throw new ArgumentOutOfRangeException("You cannot deposit less than 10$!");
                }
                base.Balance = value;
            }
        }

        public decimal WitdrawAmount
        {
            set
            {
                if (value > base.Balance)
                {
                    throw new ArgumentOutOfRangeException("You cant withdraw more than the balance of the account!");
                }
                base.Balance = -value;
            }
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (base.Balance > 0 && base.Balance < 1000)  // because 0 is not positive number
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(months);
            }
        }
    }
}
