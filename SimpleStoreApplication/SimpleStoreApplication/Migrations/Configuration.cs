namespace SimpleStoreApplication.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SimpleStoreApplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleStoreApplication.Data.SimpleStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleStoreApplication.Data.SimpleStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //1. Kategori üzerinden ürün ekle:
            //context.Categories.Add(new Category
            //{
            //    Name = "Edebiyat",
            //    Products = new List<Product> {
            //    new Product {
            //        ProductName = "Ay'a iniş",
            //        Price = 20,
            //        Description = "Jules Verne'in müthiş kitabı"
            //    }
            //}
            //});

            //Category felsefeKategorisi = new Category { Name = "Felsefe" };
            //context.Categories.Add(felsefeKategorisi);          
            ////ürün ve kategoriyi ekle:
            //context.Products.Add(new Product { ProductName = "Toplum Sözleşmesi", Description = "J.J Rousseu'nun kitabı", Price = 10,Category=felsefeKategorisi });
            ////sadece kategori
            //context.Categories.Add(new Category { Name = "Araştırma" });

            ////Persistence API
            //context.SaveChanges();



        }
    }
}
