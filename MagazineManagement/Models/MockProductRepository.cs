using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineManagement.Models
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> _productsList;

        public MockProductRepository()
        {
            _productsList = new List<Product>()
            {
                new Product() {Id = 1, Name = "green tea", Category = Cat.Drinks, Value = 1.2, Quantity = 112, PhotoPath = "green_tea.jpg"},
                new Product() {Id = 2, Name = "pepsi", Category = Cat.Drinks, Value = 1.0, Quantity = 12, PhotoPath = "pepsi.jpg"},
                new Product() {Id = 3, Name = "coffee", Category = Cat.Drinks, Value = 0.8, Quantity = 24, PhotoPath = "coffee.png"},
                new Product() {Id = 4, Name = "lion", Category = Cat.Beverages, Value = 1.0, Quantity = 220, PhotoPath = "lion_bar.jpg"}
            };
        }



        public Product GetProduct(int id)
        {
            return _productsList.FirstOrDefault(p => p.Id == id);
        }

        public Product GetProduct(string name)
        {
            return _productsList.FirstOrDefault(p => p.Name == name);
        }

        public IEnumerable<Product> GetAllPRoducts()
        {
            return _productsList;
        }

        public Product AddProduct(Product product)
        {
            product.Id = _productsList.Max(p => p.Id) + 1;
            _productsList.Add(product);
            //Product newProduct = _productsList.FirstOrDefault
            return product;
        }
    }
}
