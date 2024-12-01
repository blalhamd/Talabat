namespace Talabat.Core.DTos.Order.Responses
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string PictureUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public int Qunatity { get; set; }
        public int OrderId { get; set; }
    }
}
