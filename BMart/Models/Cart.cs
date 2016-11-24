using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class Cart
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public CartDetails CartDetails { get; set; }

        public string UserId { get; set; }

        public int PaymentOptionId { get; set; }
        [ForeignKey("PaymentOptionId")]
        public PaymentOption PaymentOption { get; set; }

    }
}