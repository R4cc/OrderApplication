using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IOrderRepo
    {
        Task CreateOrder(Order order);
        Task<IEnumerable<Order>> GetAll();
        Task<IEnumerable<OrderIndexVM>> GetAllOrderIndexVM();
        Task<Order> GetOrder(int orderId);
        Task<IEnumerable<OrderPosition>> GetOrderPositionsFromOrderId(int orderId);
        Task<IEnumerable<Order>> GetOrdersFromUser(string userId);
        Task RemoveOrder(int orderId);
        Task UpdateOrder(Order order);
    }
}