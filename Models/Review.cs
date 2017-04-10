using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCReviewSite.Models
{
    public class Review
    {
        // Properties
        [Key]
        public int ID { get; set; }
        public string Model { get; set; }
        public int UserRating { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}