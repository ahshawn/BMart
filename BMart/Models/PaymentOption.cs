using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class PaymentOption
    {
        public int paymentOptionID { get; set; }
        public string paymentType { get; set; }
        public string paymentApiKey { get; set; }
        public string paymentAvailable { get; set; }
    }
}