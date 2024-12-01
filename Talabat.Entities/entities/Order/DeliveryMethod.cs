namespace Talabat.Entities.entities.Order
{
    public class DeliveryMethod : BaseEntity
    {
        public string ShortName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Cost { get; set; }
        public string DeliveryTime { get; set; } = null!; // the delivery in 3 days
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
