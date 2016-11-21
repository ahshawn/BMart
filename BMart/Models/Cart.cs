using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class Cart
    {
        public int cartID { get; set; }
        [Required]
        public int sessionID { get; set; }


    }
}