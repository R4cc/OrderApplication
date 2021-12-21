using Microsoft.EntityFrameworkCore;
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

        public async Task<ApplicationUser[]> GetAll()
        {
            return await db.Users.ToArrayAsync();
        }

        public async Task<ApplicationUser> GetUser(string Id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == Id);
            return user;
        }

        public async Task<ApplicationUser> GetUserByLoginName(string username)
        {
            return db.Users.FirstOrDefault(u => u.UserName == username);
        }

        public async Task Create(ApplicationUser user)
        {
            await db.Users.AddAsync(user);
        }

        public async Task Delete(string Id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == Id);
            db.Users.Remove(user);
        }

        public async Task<UserIndexVM[]> GetAllUserIndexVM()
        {

            var user = db.Users.Select(u => new UserIndexVM
            {
                UserId = u.Id,
                FullName = u.FName + " " + u.LName,
                LoginName = u.UserName
            });

            return await user.OrderBy(e => e.UserId).ToArrayAsync();
        }
    }
}
