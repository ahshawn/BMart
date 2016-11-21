using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class PaymentOption
    {
        [Required]
        [Key]
        public int OptionId { get; set; }
        public string Type { get; set; }
        public string ApiKey { get; set; }
        public string Available { get; set; }
    }
}