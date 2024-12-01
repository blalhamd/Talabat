namespace Talabat.Entities.entities
{
    public class Basket
    {
        public string Id { get; set; } = null!; // must be string beacuse it's will be GUID
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public decimal SubTotal { get; set; } = 0m;
        public int? DeliveryMethodId { get; set; }
        public decimal ShippingCost { get; set; } = 0;
        public string PaymentIntentId { get; set; } = string.Empty;
        public string ClientSecret { get; set; } = string.Empty;
        public Basket() { }
        public Basket(string id)
        {
            Id = id;
        }

    }
}
