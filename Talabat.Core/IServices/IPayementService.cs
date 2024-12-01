namespace Talabat.Core.IServices
{
    public interface IPayementService
    {
        Task<BasketDto> CreateOrUpdatePaymentIntent(string basketId);
    }
}
