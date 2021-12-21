using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApplicationServer.Web.Data.Models
{
    [Table("OrderPositions", Schema = "ord")]
    public class OrderPosition
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        [Key]
        public int OrderPositionId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}