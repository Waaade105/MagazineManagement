using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Coffee",
                Quantity = 156,
                Value = 1.39,
                Category = Cat.Drinks,
                PhotoPath = "~/images/no_product.png"
            },
            new Product
            {
                Id = 2,
                Name = "Green Tea",
                Quantity = 53,
                Value = 1.29,
                Category = Cat.Drinks,
                PhotoPath = "~/images/no_product.png"
            });
        }
    }
}
