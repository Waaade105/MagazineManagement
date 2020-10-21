﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineManagement.Models
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly ProductDbContext context;

        public SQLProductRepository(ProductDbContext context)
        {
            this.context = context;
        }
        public Product AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public Product deleteProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.Id == id);
            if(product != null) { 
                context.Products.Remove(product);
                context.SaveChanges();
            }
            return product;
        }

        public IEnumerable<Product> GetAllPRoducts()
        {
            return context.Products;
        }

        public Product GetProduct(int id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product GetProduct(string name)
        {
            Product product = context.Products.FirstOrDefault(p => p.Name == name);
            return product;

        }

        public Product UpdateProduct(Product productToBeUpdated)
        {
            var product =  context.Products.Attach(productToBeUpdated);
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return productToBeUpdated;
        }
    }
}
