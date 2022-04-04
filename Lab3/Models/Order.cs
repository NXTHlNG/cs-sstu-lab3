using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        public string Description { get; set; }
        
        [Range(1, Int32.MaxValue)]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}