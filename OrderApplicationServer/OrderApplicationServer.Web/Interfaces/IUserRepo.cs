using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;

namespace OrderApplicationServer.Web.Interfaces
{
    public interface IUserRepo
    {
        Task Create(ApplicationUser user);
        Task Delete(string Id);
        Task<ApplicationUser[]> GetAll();
        Task<UserIndexVM[]> GetAllUserIndexVM();
        Task<ApplicationUser> GetUser(string Id);
        Task<ApplicationUser> GetUserByLoginName(string loginname);
    }
}