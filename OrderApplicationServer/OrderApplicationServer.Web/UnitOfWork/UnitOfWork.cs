using OrderApplicationServer.Web.Data;
using OrderApplicationServer.Web.Data.Repositories;
using OrderApplicationServer.Web.Interfaces;

namespace OrderApplicationServer.Web.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext db;
        private IOrderRepo _orderRepo;
        private IProductRepo _productRepo;
        private IUserRepo _userRepo;

        public UnitOfWork(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IUserRepo IUserRepo
        {
            get
            {
                return _userRepo = _userRepo ?? new UserRepo(db);
            }
        }
        public IOrderRepo IOrderRepo
        {
            get
            {
                return _orderRepo = _orderRepo ?? new OrderRepo(db);
            }
        }

        public IProductRepo IProductRepo
        {
            get
            {
                return _productRepo = _productRepo ?? new ProductRepo(db);
            }
        }
        public async Task SaveChangesAsync()
        {
            await db.SaveChangesAsync();
        }

    }
}
