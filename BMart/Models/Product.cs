using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Product
    {
public int Id { get; set; }
        [Required]
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productQuantity { get; set; }
        

    }
}