using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IOrderRepo
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetOrder(int orderId);
        Task CreateOrder(Order order);
        Task UpdateOrder(Order order);
        Task RemoveOrder(int orderId);
        Task<IEnumerable<Order>> GetOrdersFromUser(string userId);
        Task<IEnumerable<OrderPosition>> GetOrderPositionsFromOrderId(int orderId);
        Task<IEnumerable<OrderIndexVM>> GetAllOrderIndexVM();
    }
}