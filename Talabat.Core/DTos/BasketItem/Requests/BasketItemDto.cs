namespace Talabat.Core.DTos.BasketItem.Requests
{
    public class BasketItemDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string PictureUrl { get; set; } = null!;

        [Required]
        [Range(0.1, double.MaxValue,ErrorMessage = "Price must be greater than 0.1.")] // made it double beacuse default value(0.1) is double and two parameter must are the same type.
        public decimal Price { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Minimum value for Quantity is 1.")]
        public int Quantity { get; set; }

        [Required]
        public string Brand { get; set; } = null!;

        [Required]
        public string Type { get; set; } = null!;
    }
}
