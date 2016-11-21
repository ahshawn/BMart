using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class FaQ
    {
        [Required]
        public int faqID { get; set; }
        public string faqQuestion { get; set; }
        public string faqAnswer { get; set; }

    }
}