namespace Cosmetics.Products
{
    using Contracts;
    using System.Collections.Generic;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> shoppingCart;

        public ShoppingCart()
        {
            shoppingCart = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            if (product != null)
            {
                this.shoppingCart.Add(product);
            }
        }

        public void RemoveProduct(IProduct product)
        {
            this.shoppingCart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.shoppingCart.Contains(product))
            {
                return true;
            }
            return false;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0M;

            foreach (var product in this.shoppingCart)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
