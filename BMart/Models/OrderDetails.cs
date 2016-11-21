using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class OrderDetails
    {
        [Required]
        public int orderDetails { get; set; }
        

    }
}