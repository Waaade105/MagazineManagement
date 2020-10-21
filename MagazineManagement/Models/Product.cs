using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="Name cannot be longer than 30 chars")]
        public string Name { get; set; }
        public  Cat Category { get; set; }
        [Required]
        //[RegularExpression(@"[0-9,.$]", ErrorMessage = "invalid input")]   /*dodac tutaj przecinek */
        public double Value { get; set; }
        [Required]

        public int Quantity { get; set; }   /*jakbym mial double to moge pisac literki w formie createprodcut - ale przy int jest wymuszone ze tylko cyfry */
        public string PhotoPath { get; set; }


        

    }
} 
