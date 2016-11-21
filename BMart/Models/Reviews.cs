using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Reviews
    {
        public int reviewsID { get; set;}
        [Required]
        public string reviewDescription { get; set; }
        public string reviewRatings { get; set; }
        public DateTime reviewDate { get; set;}

    }
}