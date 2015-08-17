namespace _02.BankAccounts
{
    using System;

    public class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime dateOpened;

        

        public Account(Customer customer, decimal balance, decimal interestRate, DateTime dateOpened)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.DateOpened = dateOpened;
        }

        public Customer Customer 
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }
        public decimal Balance {
            get 
            {
                return this.balance;
            }
            protected set
            {
                if (this.balance == null)
                {
                    this.balance = 0;
                }
                this.balance += value;
            }
        }
        public decimal InterestRate {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }
        private DateTime DateOpened
        {
            set 
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentOutOfRangeException("Date of account creation is not valid!");
                }
                dateOpened = value; 
            }
        }
        public virtual decimal CalculateInterestAmount(int months)
        {
            return months * this.interestRate;
        }
    }
}
