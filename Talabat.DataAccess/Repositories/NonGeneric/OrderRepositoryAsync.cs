namespace Talabat.DataAccess.Repositories.NonGeneric
{
    public class OrderRepositoryAsync : GenericRepositoryAsync<Order>, IOrderRepositoryAsync
    {
        public OrderRepositoryAsync(AppDbContext dbcontext) : base(dbcontext) { }
       
    }
}
