using OrderApplicationServer.Web.Data.Models;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetProduct(int productId);
        Task CreateProduct(Product product);
        Task CreateProperty(ProductProperty property);
        Task UpdateProduct(Product product);
        Task UpdateProperty(ProductProperty property);
        Task RemoveProduct(int productId);
        Task RemoveProperty(ProductProperty property);
        Task RemovePropertyFromProduct(ProductProperty property, int productId);
        Task AddPropertyToProduct(ProductProperty property, int productId);
        Task<IEnumerable<ProductProperty>> GetAllProductProperties();
        Task<ProductProperty> GetProductProperty(int productPropertyId);
    }
}