namespace Talabat.Core.DTos.Order.Requests
{
    public class CreateOrderRequest
    {
        [Required]
        public string BasketId { get; set; } = null!;

        [Required]
        public int DeliveryMethodId { get; set; }

        public AddressOrderDto Address { get; set; } = null!;
    }
}
