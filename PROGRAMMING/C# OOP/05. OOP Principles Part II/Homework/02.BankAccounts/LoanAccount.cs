namespace _02.BankAccounts
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal strartBalance, decimal interestRate, DateTime date)
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
                base.Balance = - value;
            }
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (base.Customer.TypeOfCustomer == CustomerType.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 2);
                }
            }
        }
    }
}
