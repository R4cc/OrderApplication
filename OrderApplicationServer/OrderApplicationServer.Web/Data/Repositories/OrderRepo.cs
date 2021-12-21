using Microsoft.EntityFrameworkCore;
using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;
using OrderApplicationServer.Web.Interfaces;

namespace OrderApplicationServer.Web.Data.Repositories
{
    /// <summary>
    /// Gets, Creates, Edits and Deletes DB Entries with EF
    /// </summary>
    public class OrderRepo : IOrderRepo
    {
        private ApplicationDbContext db;

        public OrderRepo(ApplicationDbContext _db)
        {
            db = _db;
        }

        public async Task<Order[]> GetAll()
        {
            return await db.Order.ToArrayAsync();
        }

        /// <summary>
        /// Gets all Orders from a user
        /// </summary>
        /// <param name="id">UserID</param>
        /// <returns>All Orders from a given UserID</returns>
        public async Task<Order[]> GetOrdersFromUser(string id)
        {
            return await db.Order.Where(u => u.UserId == id).ToArrayAsync();
        }

        /// <summary>
        /// Gets single Order by ID
        /// </summary>
        /// <param name="id">OrderID</param>
        /// <returns>returns Single Order</returns>
        public async Task<Order> GetOrder(int id)
        {
            return db.Order.FirstOrDefault(u => u.OrderId == id);
        }

        /// <summary>
        /// Creates an Order
        /// </summary>
        /// <param name="order">New Order instance</param>
        public async Task CreateOrder(Order order)
        {
            await db.Order.AddAsync(order);
        }

        /// <summary>
        /// Removes order with matching ID
        /// </summary>
        /// <param name="Id">OrderID from Order to remove</param>
        public async Task RemoveOrder(int Id)
        {
            var order = db.Order.FirstOrDefault(u => u.OrderId == Id);
            db.Order.Remove(order);
        }

        /// <summary>
        /// Updates the Data in the DB
        /// </summary>
        /// <param name="order">Updated instance of order</param>
        public async Task UpdateOrder(Order order)
        {
            db.Order.Update(order);
        }

        /// <summary>
        /// Gets all Orders and puts them in a Order VM List (To display only needed information)
        /// </summary>
        /// <returns>Translated IEnumerable into OrderIndexVM</returns>
        public async Task<IEnumerable<OrderIndexVM>> GetAllOrderIndexVM()
        {

            var orders = db.Order.Select(o => new OrderIndexVM
            {
                OrderId = o.OrderId,
                UserId = o.UserId,
                OrderDate = o.OrderDate
            });

            return await orders.OrderBy(o => o.OrderId).ToArrayAsync();
        }

        /// <summary>
        /// Gets all Orderposition from provided OrderID
        /// </summary>
        /// <param name="orderId">Order ID</param>
        /// <returns>IEnumerable of OrderPositions from OrderID</returns>
        public async Task<IEnumerable<OrderPosition>> GetOrderPositionsFromOrderId(int orderId)
        {
            return await db.OrderPosition.Where(o => o.OrderId == orderId).ToArrayAsync();
        }
    }
}