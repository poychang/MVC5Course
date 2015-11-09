using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class NewProductVM
    {
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [Range(1,999)]
        public decimal Price { get; set; }
    }
}