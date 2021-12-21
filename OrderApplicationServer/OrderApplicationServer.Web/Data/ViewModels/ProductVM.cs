namespace OrderApplicationServer.Web.Data.ViewModels
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public List<ProductPropertyVM> ProductProperties { get; set; }
    }
}