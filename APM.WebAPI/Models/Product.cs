using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APM.WebAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }

        [Required( ErrorMessage = "Product code is required", AllowEmptyStrings = false)]
        [MinLength(5, ErrorMessage = "Product code min length is 5 characters")]
        [MaxLength(11, ErrorMessage = "Product code max length is 11 characters")]
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}