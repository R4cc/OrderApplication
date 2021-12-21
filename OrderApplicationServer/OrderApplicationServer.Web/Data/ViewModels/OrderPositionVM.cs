using System.ComponentModel.DataAnnotations;

namespace OrderApplicationServer.Web.Data.ViewModels
{
    public class OrderPositionVM
    {
        public int OrderId { get; set; }

        public int OrderPositionId { get; set; }

        public int ProductId { get; set; }
        public ProductVM Product { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }
    }
}
