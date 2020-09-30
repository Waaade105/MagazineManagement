using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Cat Category { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }
        public string PhotoPath { get; set; }


        

    }
}
