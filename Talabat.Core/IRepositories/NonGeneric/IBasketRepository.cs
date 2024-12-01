namespace Talabat.Core.IRepositories.NonGeneric
{
    public interface IBasketRepository
    {
        Task<Basket?> GetBasketAsync(string BasketId);
        Task<Basket?> UpdateBasketAsync(Basket basket);
        Task<bool> DeleteBasketAsync(string BasketId);
    }
}
