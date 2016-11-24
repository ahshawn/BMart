using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace BMart.Models
{
    public class Reviews
    {
        [Required]
        [Key]
        public int Id { get; set;}
        public string Description { get; set; }
        public string Ratings { get; set; }
        public DateTime Date { get; set;}
        public string UserId { get; set; }

        public Product Product { get; set; }
        
        public int ProductId { get; set; }

    }
}