using Microsoft.EntityFrameworkCore;
using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;
using OrderApplicationServer.Web.Interfaces;

namespace OrderApplicationServer.Web.Data.Repositories
{
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

        public async Task<Order[]> GetOrdersFromUser(string id)
        {
            return await db.Order.Where(u => u.UserId == id).ToArrayAsync();
        }

        public async Task<Order> GetOrder(int Id)
        {
            return db.Order.FirstOrDefault(u => u.OrderId == Id);
        }

        public async Task Create(Order order)
        {
            await db.Order.AddAsync(order);
        }

        public async Task Delete(int Id)
        {
            var order = db.Order.FirstOrDefault(u => u.OrderId == Id);
            db.Order.Remove(order);
        }

        public async Task Modify(Order order)
        {
            db.Order.Update(order);
        }

        public async Task<OrderIndexVM[]> GetAllOrderIndexVM()
        {

            var orders = db.Order.Select(o => new OrderIndexVM
            {
                OrderId = o.OrderId,
                UserId = o.UserId,
                OrderDate = o.OrderDate
            });

            return await orders.OrderBy(o => o.OrderId).ToArrayAsync();
        }

        public async Task<OrderPosition[]> GetOrderPositionsFromOrderId(int orderId)
        {
            return await db.OrderPosition.Where(o => o.OrderId == orderId).ToArrayAsync();
        }
    }
}