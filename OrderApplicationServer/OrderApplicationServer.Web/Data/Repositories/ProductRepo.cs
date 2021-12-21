using Microsoft.EntityFrameworkCore;
using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Interfaces;

namespace OrderApplicationServer.Web.Data.Repositories
{
    /// <summary>
    /// Gets, Edits, Creates and Modifies data related to products on the DB with EF 6
    /// </summary>
    public class ProductRepo : IProductRepo
    {
        private ApplicationDbContext _db;

        public ProductRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Gets all Products from the DB and converts them to a List
        /// </summary>
        /// <returns>All Products in DB</returns>
        public async Task<IEnumerable<Product>> GetAll()
        {
            return _db.Product;
        }

        /// <summary>
        /// Gets a specific Product which is found by ProductId. The ProductProperties are included.
        /// </summary>
        /// <param name="productId">Represents the ProductId in the DB</param>
        public async Task<Product> GetProduct(int productId)
        {
            return _db.Product.Include(x => x.ProductProperties)
                              .FirstOrDefault(p => p.ProductId == productId);
        }

        /// <summary>
        /// Creates a new Product (No automatic SaveChanges()!)
        /// </summary>
        /// <param name="product">New Product to create</param>
        public async Task CreateProduct(Product product)
        {
            await _db.Product.AddAsync(product);
        }

        /// <summary>
        /// Deletes a Product by ProductId
        /// </summary>
        /// <param name="productId">ProductId to find Product in DB</param>
        public async Task RemoveProduct(int productId)
        {
            var product = _db.Product.FirstOrDefault(p => p.ProductId == productId);
            _db.Product.Remove(product);
        }

        /// <summary>
        /// Modify Product
        /// </summary>
        /// <param name="product">Modified Product (old product is found by same ProductId)</param>
        public async Task UpdateProduct(Product product)
        {
            _db.Update(product);
        }

        /// <summary>
        /// Gets all ProductProperties
        /// </summary>
        /// <returns>IEnumerable of ProductProperties</returns>
        public async Task<IEnumerable<ProductProperty>> GetAllProductProperties()
        {
            return _db.ProductProperties;
        }

        /// <summary>
        /// Gets a ProductProperty by ProductPropertyId
        /// </summary>
        /// <param name="productPropertyId">ProductPropertyId to find the ProductProperty in the DB</param>
        /// <returns>ProductProperty</returns>
        public async Task<ProductProperty> GetProductProperty(int productPropertyId)
        {
            return _db.ProductProperties.FirstOrDefault(p => p.ProductPropertyId == productPropertyId);
        }

        /// <summary>
        /// Adds a given ProductProperty to a Product
        /// </summary>
        /// <param name="property">Property instance to add to Product</param>
        /// <param name="ProductId">ProductId of Product to add the property to</param>
        /// <returns></returns>
        public async Task AddPropertyToProduct(ProductProperty property, int ProductId)
        {
            var prod = await GetProduct(ProductId);
            prod.ProductProperties.Add(property);
            _db.Update(prod);
            // This doesnt work if done in UOW for some reason
            //await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Removes a given ProductProperty from a Product
        /// </summary>
        /// <param name="property">Instance of ProductProperty to remove</param>
        /// <param name="productId">ProductId of Product to remove the property from</param>
        /// <returns></returns>
        public async Task RemovePropertyFromProduct(ProductProperty property, int productId)
        {
            var prod = await GetProduct(productId);
            var propertyToRemove = await GetProductProperty(property.ProductPropertyId);
            prod.ProductProperties.Remove(propertyToRemove);
            _db.Update(prod);

            // This doesnt work if done in UOW for some reason
            //await _db.SaveChangesAsync();
        }

        public async Task CreateProperty(ProductProperty property)
        {
            _db.Add(property);
        }

        public async Task UpdateProperty(ProductProperty property)
        {
            _db.Update(property);
        }

        public async Task RemoveProperty(ProductProperty property)
        {
            _db.Remove(property);
        }
    }
}