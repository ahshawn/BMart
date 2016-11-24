using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        
        public string Status { get; set; }

        public string UserId { get; set; }


        public OrderDetails OrderDetails { get; set; }
        public int PaymentOptionId { get; set; }
        [ForeignKey("PaymentOptionId")]
        public PaymentOption PaymentOption { get; set; }
    }
}