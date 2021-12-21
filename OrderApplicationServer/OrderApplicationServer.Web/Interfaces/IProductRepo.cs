using OrderApplicationServer.Web.Data.Models;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IProductRepo
    {
        Task AddPropertyToProduct(ProductProperty property, int productId);
        Task CreateProduct(Product product);
        Task CreateProperty(ProductProperty property);
        Task RemoveProduct(int productId);
        Task<IEnumerable<Product>> GetAll();
        Task<IEnumerable<ProductProperty>> GetAllProductProperties();
        Task<Product> GetProduct(int productId);
        Task<ProductProperty> GetProductProperty(int productPropertyId);
        Task UpdateProduct(Product product);
        Task RemovePropertyFromProduct(ProductProperty property, int productId);
        Task UpdateProperty(ProductProperty property);
        Task RemoveProperty(ProductProperty property);
    }
}