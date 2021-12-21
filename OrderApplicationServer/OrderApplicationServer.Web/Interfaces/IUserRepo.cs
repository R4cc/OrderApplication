using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IUserRepo
    {
        Task<IEnumerable<ApplicationUser>> GetAll();
        Task<IEnumerable<UserIndexVM>> GetAllUserIndexVM();
        Task<ApplicationUser> GetUser(string Id);
        Task Remove(string Id);
    }
}