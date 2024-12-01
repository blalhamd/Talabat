namespace Talabat.DataAccess.Unit
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            ProductRepository = new ProductRepositoryAsync(appDbContext);
            DeliveryMethodRepositoryAsync = new GenericRepositoryAsync<DeliveryMethod>(appDbContext);
            OrderRepository = new OrderRepositoryAsync(appDbContext);
            RepositoryAsync = new GenericRepositoryAsync<T>(appDbContext);
        }

        public IProductRepositoryAsync ProductRepository { get; }
        public IGenericRepositoryAsync<T> RepositoryAsync {  get; }
        public IOrderRepositoryAsync OrderRepository { get; }
        public IGenericRepositoryAsync<DeliveryMethod> DeliveryMethodRepositoryAsync {  get; }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public async ValueTask DisposeAsync()
        {
            await _appDbContext.DisposeAsync();
        }

        public Task RollBackAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
