﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApplicationServer.Web.Data.Models
{
    [Table("ProductProperties", Schema = "prod")]
    public class ProductProperty
    {
        [Key]
        public int ProductPropertyId { get; set; }
        [StringLength(250, MinimumLength = 2)]
        public string Title { get; set; }
        [StringLength(350, MinimumLength = 2)]
        public string Notes { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}