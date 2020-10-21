using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineManagement.Models
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        Product GetProduct(string name);
        IEnumerable <Product> GetAllPRoducts();
        Product AddProduct(Product product);
        Product UpdateProduct(Product productToBeUpdated);
        Product deleteProduct(int id);


    }
}
