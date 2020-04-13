using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Models
{
    public static class FakeProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { ProductId=1, ProductName="Çürümenin Kitabı", Description="Felsefe denemeleri...", Price=10},
            new Product { ProductId=2, ProductName="Örnek kitap 2", Description="Açıklama 2", Price=10},
            new Product { ProductId=3, ProductName="Örnek kitap 3", Description="Açıklama 3", Price=15},
            new Product { ProductId=4, ProductName="Örnek kitap 4", Description="Açıklama 4", Price=30},
            new Product { ProductId=5, ProductName="Örnek kitap 5", Description="Açıklama 5", Price=33},
            new Product { ProductId=6, ProductName="Örnek kitap 6", Description="Açıklama 6", Price=22},
            new Product { ProductId=7, ProductName="Örnek kitap 7", Description="Açıklama 7", Price=15},
            new Product { ProductId=8, ProductName="Örnek kitap 8", Description="Açıklama 8", Price=18}
        };


       // private static List<Category> categories = new List<Category>();
        public static List<Product> GetProducts()
        {
            return products;
        }
    }
}