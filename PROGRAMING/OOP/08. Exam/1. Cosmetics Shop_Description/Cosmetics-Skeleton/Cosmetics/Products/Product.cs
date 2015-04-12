namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Common;
    using System;
    using System.Text;

    public abstract class Product : IProduct
    {
        private const string ProductNameMinAndMaxSymbolsErrorMessage = "Product name must be between {0} and {1} symbols long!";
        private const string ProductBrandMinAndMaxSymbolsErrorMessage = "Product brand must be between {0} and {1} symbols long!";
        private const string ProductPrintLine = "- {0} - {1}:\r\n  * Price: ${2}\r\n  * For gender: {3}";
        private const int MinSymbolsForProductName = 3;
        private const int MaxSymbolsForProductName = 10;
        private const int MinSymbolsForProductBrand = 2;
        private const int MaxSymbolsForProductBrand = 10;

        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty!");
                }
                if (value.Length < MinSymbolsForProductName || value.Length > MaxSymbolsForProductName)
                {
                    throw new ArgumentException(String.Format(ProductNameMinAndMaxSymbolsErrorMessage, MinSymbolsForProductName, MaxSymbolsForProductName));
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product brand cannot be null or empty!");
                }
                if (value.Length < MinSymbolsForProductBrand || value.Length > MaxSymbolsForProductBrand)
                {
                    throw new ArgumentException(String.Format(ProductBrandMinAndMaxSymbolsErrorMessage, MinSymbolsForProductBrand, MaxSymbolsForProductBrand));
                }
                this.brand = value;
            }

        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                this.price = value;
            }
        }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            var result = new StringBuilder();

            result.Append(String.Format(ProductPrintLine,
                                            this.brand,
                                            this.name,
                                            this.price,
                                            this.Gender
                                            ));
            
            return result.ToString();
        }
    }
}
