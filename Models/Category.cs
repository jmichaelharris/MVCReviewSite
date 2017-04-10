using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCReviewSite.Models
{
    public class Category
    {
        // Properties
        [Key]
        public int ID { get; set; }
        public string TechName { get; set; }

        // Navigation Properties
        public virtual ICollection<Review> Reviews { get; set; }
    }
}