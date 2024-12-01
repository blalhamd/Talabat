namespace Talabat.Core.DTos.DeliveryMethod.Responses
{
    public class DeliveryMethodDto
    {
        public int Id { get; set; }
        public string ShortName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Cost { get; set; }
        public string DeliveryTime { get; set; } = null!; // the delivery in 3 days
    }
}
