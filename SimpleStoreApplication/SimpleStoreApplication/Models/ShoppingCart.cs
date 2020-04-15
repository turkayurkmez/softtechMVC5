using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public class ShoppingCart
    {
        private List<ProductInBasket> productCollection = new List<ProductInBasket>();
        public void AddToCart(Product product, int quantity)
        {


            var result = productCollection.FirstOrDefault(p => p.Product.ProductId == product.ProductId);

            if (result==null)
            {
                ProductInBasket productInBasket = new ProductInBasket { Product = product, Quantity = quantity };
                productCollection.Add(productInBasket);
            }
            else
            {
                result.Quantity += 1;
            }
        }
        public void RemoveFromCart(ProductInBasket productInBasket)
        {
            productCollection.RemoveAll(p => p.Product.ProductId == productInBasket.Product.ProductId);
        }

        public void ClearAllCart()
        {
            productCollection.Clear();
        }

        public decimal GetTotalValue()
        {
            return productCollection.Sum(x => x.Product.Price * x.Quantity);
        }
        public List<ProductInBasket> Products { get { return productCollection; } }
    }
}