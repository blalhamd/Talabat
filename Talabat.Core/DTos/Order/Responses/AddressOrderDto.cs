namespace Talabat.Core.DTos.Order.Responses
{
    public class AddressOrderDto
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;

        [Required]
        public string Cirt { get; set; } = null!;

        [Required]
        public string Street { get; set; } = null!;
    }
}
