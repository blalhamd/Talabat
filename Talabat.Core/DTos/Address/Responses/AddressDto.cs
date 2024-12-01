namespace Talabat.Core.DTos.Address.Responses
{
    public class AddressDto
    {
        public int Id { get; set; }

        [Required]
        public string State { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Street { get; set; } = null!;

        [Required]
        public int ZipCode { get; set; }
    }
}
