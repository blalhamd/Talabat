namespace Talabat.Core.IServices
{
    public interface IOrderService
    {
        Task<OrderResponse> CreateOrderAsync(string BuyerEmail, CreateOrderRequest request);
        Task<IList<OrderResponse>> GetOrdersForUserAsync(string BuyerEmail);
        Task<OrderResponse> GetOrderByIdAsync(string BuyerEmail, int orderId);
        Task<IList<DeliveryMethodDto>> GetDeliveryMethodsAsync();
    }
}
