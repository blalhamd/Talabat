namespace Talabat.Entities.entities.Order
{
    public class Address // that belong to Order, won't be table in DB...
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Cirt { get; set; } = null!;
        public string Street { get; set; } = null!;
    }
}
