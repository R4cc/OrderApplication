namespace OrderApplicationServer.Web.Data.Models
{
    public class SelectVM<T>
    {
        public T Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
