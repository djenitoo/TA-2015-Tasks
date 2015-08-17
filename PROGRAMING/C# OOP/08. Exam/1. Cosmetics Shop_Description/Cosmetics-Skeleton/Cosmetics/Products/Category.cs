namespace Cosmetics.Products
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Category : ICategory
    {
        private const string CategoryNameMinAndMaxSymbolsErrorMessage = "Category name must be between {0} and {1} symbols long!";
        private const string NotFoundProductErrorMessage = "Product {0} does not exist in category {1}!";
        private const string CategoryHeadLineString = "{0} category - {1} {2} in total";
        private const string CategoryOneProduct = "product";
        private const string CategotyMoreThanOneProduct = "products";
        private const int One = 1;
        private const int MinSymbolsForCategoryName = 2;
        private const int MaxSymbolsForCategoryName = 15;

        private string name;
        private IList<IProduct> category;

        public Category(string name)
        {
            this.Name = name;
            this.category = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < MinSymbolsForCategoryName || value.Length > MaxSymbolsForCategoryName)
                {
                    throw new ArgumentException(String.Format(CategoryNameMinAndMaxSymbolsErrorMessage, MinSymbolsForCategoryName, MaxSymbolsForCategoryName));
                }
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.category.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!(this.category.Contains(cosmetics)))
            {
                throw new ArgumentException(String.Format(NotFoundProductErrorMessage, cosmetics, this.name));
            }

            this.category.Remove(cosmetics);
        }

        public string Print()
        {
            var sortedCategory = this.category
                                    .OrderBy(c => c.Brand)
                                    .ThenByDescending(c => c.Price);

            var result = new StringBuilder();
            
            result.AppendLine(String.Format(CategoryHeadLineString, 
                                            this.name, 
                                            this.category.Count,
                                            this.category.Count != One ? CategotyMoreThanOneProduct : CategoryOneProduct));

            foreach (var cosmetic in sortedCategory)
            {
                result.AppendLine(cosmetic.Print());
            }

            return result.ToString().Trim();
        }

        
    }
}
