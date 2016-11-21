using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class Cart
    {
        [Required]
        public int cartID { get; set; }
        public int sessionID { get; set; }


    }
}