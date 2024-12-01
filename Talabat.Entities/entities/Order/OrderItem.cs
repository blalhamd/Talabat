namespace Talabat.Entities.entities.Order
{
    public class OrderItem : BaseEntity
    {
        public ProudctItemOrdered Product { get; set; } = null!;
        public decimal Price { get; set; }
        public int Qunatity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
