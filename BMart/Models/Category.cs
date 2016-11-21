using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Category
    {
        [Required]
        public int categoryID { get; set; }
        
        public string categoryName { get; set; }
    }
}