using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;
using OrderApplicationServer.Web.Interfaces;

namespace OrderApplicationServer.Web.Data.Repositories
{
    public class UserRepo : IUserRepo
    {
        private ApplicationDbContext db;

        public UserRepo(ApplicationDbContext _db)
        {
            db = _db;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAll()
        {
            return db.Users;
        }

        public async Task<ApplicationUser> GetUser(string Id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == Id);
            return user;
        }

        public async Task Remove(string Id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == Id);
            db.Users.Remove(user);
        }

        public async Task<IEnumerable<UserIndexVM>> GetAllUserIndexVM()
        {
            var user = db.Users.Select(u => new UserIndexVM
            {
                UserId = u.Id,
                FullName = u.FName + " " + u.LName,
                LoginName = u.UserName
            });

            return user.OrderBy(e => e.UserId);
        }
    }
}