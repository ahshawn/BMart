using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Quantity { get; set; }
        public double Cost { get; set; }
        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}