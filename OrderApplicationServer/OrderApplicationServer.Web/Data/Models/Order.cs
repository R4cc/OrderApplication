using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApplicationServer.Web.Data.Models
{
    [Table("Orders", Schema = "ord")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}