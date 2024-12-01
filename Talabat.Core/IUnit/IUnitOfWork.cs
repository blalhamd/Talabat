namespace Talabat.Core.IUnit
{
    public interface IUnitOfWork<T>: IAsyncDisposable where T : BaseEntity
    {
        IGenericRepositoryAsync<T> RepositoryAsync {  get; }
        IGenericRepositoryAsync<DeliveryMethod> DeliveryMethodRepositoryAsync {  get; }
        IProductRepositoryAsync ProductRepository { get; }
        IOrderRepositoryAsync OrderRepository { get; }
        Task<int> SaveAsync();
        Task CommitAsync();
        Task RollBackAsync();

    }
}
