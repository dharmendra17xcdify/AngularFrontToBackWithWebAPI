using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APM.WebAPI.Models
{
    public class Product
    {
        [Required]
        [MinLength(5), MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ProductCode { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required( ErrorMessage = "Product code is required", AllowEmptyStrings = false)]
        [MinLength(5, ErrorMessage = "Product Name min length is 5 characters")]
        [MaxLength(11, ErrorMessage = "Product Name max length is 11 characters")]
        public string ProductName { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}