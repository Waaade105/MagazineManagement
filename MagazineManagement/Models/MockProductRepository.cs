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
                new Product() {Id = 1, Name = "green tea", Category = "drinks", Value = 1.2, Quantity = 112},
                new Product() {Id = 2, Name = "pepsi", Category = "drinks", Value = 1.0, Quantity = 12},
                new Product() {Id = 3, Name = "coffee", Category = "drinks", Value = 0.8, Quantity = 24},
                new Product() {Id = 4, Name = "lion", Category = "beverages", Value = 1.0, Quantity = 220}
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
    }
}
