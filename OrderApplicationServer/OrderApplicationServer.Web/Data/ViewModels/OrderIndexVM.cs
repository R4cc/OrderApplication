using System.ComponentModel.DataAnnotations;

namespace OrderApplicationServer.Web.Data.ViewModels
{
    public class OrderIndexVM
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserFullName { get; set; }
    }
}
