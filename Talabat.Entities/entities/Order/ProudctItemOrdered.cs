namespace Talabat.Entities.entities.Order
{
    public class ProudctItemOrdered // won't be table in DB...
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string PictureUrl { get; set; } = null!;
    }
}
