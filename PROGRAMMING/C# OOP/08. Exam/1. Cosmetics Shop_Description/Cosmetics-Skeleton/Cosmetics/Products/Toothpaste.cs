namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Toothpaste : Product, IToothpaste
    {
        private const string IngredientNameMinAndMaxSymbolsErrorMessage = "Each ingredient must be between {0} and {1} symbols long!";
        private const string IngredientsLine = "  * Ingredients: {0}";
        private const int MinSymbolsForIngredientName = 4;
        private const int MaxSymbolsForIngredientName = 12;


        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base (name, brand, price, gender)
        {
            this.ToothpasteIngredients = ingredients;
        }

        private IList<string> ToothpasteIngredients
        {
            set
            {
                if (value.Any(ingr => ingr.Length < MinSymbolsForIngredientName || ingr.Length > MaxSymbolsForIngredientName))
                {
                    throw new ArgumentOutOfRangeException(String.Format(IngredientNameMinAndMaxSymbolsErrorMessage, MinSymbolsForIngredientName, MaxSymbolsForIngredientName));
                }

                this.ingredients = value;
            }
        }
        
        public string Ingredients
        {
            get { return String.Join(", ", this.ingredients); }
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(base.Print());

            result.Append(string.Format(IngredientsLine, this.Ingredients));

            return result.ToString().Trim();
        }

        
    }
}
