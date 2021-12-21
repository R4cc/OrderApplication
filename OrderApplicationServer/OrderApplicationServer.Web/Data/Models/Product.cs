using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApplicationServer.Web.Data.Models
{
    [Table("Products", Schema = "prod")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImgPath { get; set; }
        public ICollection<ProductProperty>? ProductProperties { get; set; }
    }
}