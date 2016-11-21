using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Ordercs
    {
        [Required]
        public int orderID { get; set; }
        
        public string orderStatus { get; set; }
        
    }
}