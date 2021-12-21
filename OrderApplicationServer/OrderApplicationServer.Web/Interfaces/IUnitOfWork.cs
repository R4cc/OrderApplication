namespace OrderApplicationServer.Web.Interfaces
{
    public interface IUnitOfWork
    {
        IOrderRepo IOrderRepo { get; }
        IProductRepo IProductRepo { get; }
        IUserRepo IUserRepo { get; }
        Task SaveChangesAsync();
    }
}