using OrderApplicationServer.Web.Data.Models;
using OrderApplicationServer.Web.Data.ViewModels;
using OrderApplicationServer.Web.Interfaces;

namespace OrderApplicationServer.Web.Data.Repositories
{
    /// <summary>
    /// Gets, Creates, Removes and Updates User Entries in the DB with EF
    /// </summary>
    public class UserRepo : IUserRepo
    {
        private ApplicationDbContext db;

        public UserRepo(ApplicationDbContext _db)
        {
            db = _db;
        }

        /// <summary>
        /// Get all Users
        /// </summary>
        /// <returns>IEnumerable of all Users</returns>
        public async Task<IEnumerable<ApplicationUser>> GetAll()
        {
            return db.Users;
        }

        /// <summary>
        /// Gets a single User
        /// </summary>
        /// <param name="userId">UserID</param>
        /// <returns>Single User</returns>
        public async Task<ApplicationUser> GetUser(string userId)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userId);
            return user;
        }

        /// <summary>
        /// Remove User by UserID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task Remove(string userId)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userId);
            db.Users.Remove(user);
        }

        /// <summary>
        /// Get all Users 
        /// </summary>
        /// <returns></returns>
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