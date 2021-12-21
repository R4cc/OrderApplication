using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IOrderRepo
    {
        Task Create(Order order);
        Task Delete(int Id);
        Task<Order[]> GetAll();
        Task<OrderIndexVM[]> GetAllOrderIndexVM();
        Task<Order> GetOrder(int Id);
        Task<OrderPosition[]> GetOrderPositionsFromOrderId(int orderId);
        Task<Order[]> GetOrdersFromUser(string id);
        Task Modify(Order order);
    }
}