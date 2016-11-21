using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        [Required]
        public string categoryName { get; set; }
    }
}