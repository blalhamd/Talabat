namespace Talabat.Core.DTos.Basket.Responses
{
    public class BasketDto
    {
        public string Id { get; set; } = null!; // must be string beacuse it's will be GUID
        public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();
        public int? DeliveryMethodId { get; set; }
        public decimal ShippingCost { get; set; } = 0;
        public string? PaymentIntentId { get; set; }
        public string? ClientSecret { get; set; }
    }
}
