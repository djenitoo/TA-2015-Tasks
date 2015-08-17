namespace _02.BankAccounts
{
    using System;

    public class Customer
    {
        private string name;
        private CustomerType customerType;

        public Customer(string name, CustomerType custromerType)
        {
            this.Name = name;
            this.TypeOfCustomer = customerType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("Name length should not be less than 6 charecters!");
                }
                this.name = value;
            }
        }
        public CustomerType TypeOfCustomer
        {
            get
            {
                return this.customerType;
            }
            set
            {
                this.customerType = value;
            }
        }
    }
}
