using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMart.Models
{
    public class Faq
    {
        [Required]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}