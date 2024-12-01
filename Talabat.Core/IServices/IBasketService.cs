namespace Talabat.Core.IServices
{
    public interface IBasketService
    {
        Task<BasketDto> GetBasket(string BasketId);
        Task<BasketDto> UpdateBasket(UpdateBasketRequest basket);
        Task<bool> DeleteBasket(string BasketId);
    }
}
