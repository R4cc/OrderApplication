using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IOrderRepo
    {
        Task CreateOrder(Order order);
        Task<Order[]> GetAll();
        Task<IEnumerable<OrderIndexVM>> GetAllOrderIndexVM();
        Task<Order> GetOrder(int id);
        Task<IEnumerable<OrderPosition>> GetOrderPositionsFromOrderId(int orderId);
        Task<Order[]> GetOrdersFromUser(string id);
        Task RemoveOrder(int Id);
        Task UpdateOrder(Order order);
    }
}