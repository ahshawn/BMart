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
        public int Id { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

    }
}