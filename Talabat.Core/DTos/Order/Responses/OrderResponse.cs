namespace Talabat.Core.DTos.Order.Responses
{
    public class OrderResponse
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; } = null!;
        public DateTimeOffset DateTime { get; set; } 
        public AddressOrderDto ShippingAddress { get; set; } = null!; 
        public int? DeliveryMethodId { get; set; }
        public DeliveryMethodOrderDto? DeliveryMethod { get; set; }
        public string OrderStatus { get; set; } = null!;
        public ICollection<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
        public decimal SubTotal { get; set; } 
        public decimal Total { get => SubTotal + (DeliveryMethod is null ? 0m : DeliveryMethod.Cost); }
        public string PaymentIntentId { get; set; } = null!;
    }
}

