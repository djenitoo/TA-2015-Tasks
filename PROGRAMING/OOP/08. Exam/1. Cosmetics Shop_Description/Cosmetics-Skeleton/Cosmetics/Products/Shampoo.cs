namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Common;
    using System;
    using System.Text;

    class Shampoo : Product, IShampoo
    {
        private const string QuantityLine = "  * Quantity: {0} ml\r\n  * Usage: {1}";

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Price = price;
            this.Usage = usage;
        }

        public uint Milliliters { get; set; }
        

        public UsageType Usage { get; private set; }

        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            protected set
            {
                base.Price = this.Milliliters * value;
            }
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(base.Print());

            result.Append(string.Format(QuantityLine, this.Milliliters, this.Usage));
            
            return result.ToString();
        }


        
    }
}
