namespace Talabat.Entities.entities.Order
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; } = null!;
        public DateTimeOffset DateTime { get; set; } = DateTimeOffset.Now; // as default
        public Address ShippingAddress { get; set; } = null!; // that address will fill it from address of user..
        public int? DeliveryMethodId { get; set; } 
        public DeliveryMethod? DeliveryMethod { get; set; } 
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending; // as default
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal SubTotal { get; set; } // = Sum(price of product as orderItem in orderItem * Quantity)
        
        [NotMapped] // because it's derived...
        public decimal Total { get => SubTotal + (DeliveryMethod is null ? 0m : DeliveryMethod.Cost); } // = SubTotal + DeliveryMethodCost
        public string PaymentIntentId { get; set; } = null!;
    }
}


