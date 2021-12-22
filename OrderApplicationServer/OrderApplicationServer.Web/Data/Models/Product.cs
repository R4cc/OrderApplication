using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApplicationServer.Web.Data.Models
{
    [Table("Products", Schema = "prod")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(250, MinimumLength = 2)]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public ICollection<ProductProperty>? ProductProperties { get; set; }
    }
}