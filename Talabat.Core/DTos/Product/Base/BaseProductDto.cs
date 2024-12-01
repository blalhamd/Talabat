using System.ComponentModel.DataAnnotations;

namespace Talabat.Core.DTos.Product.Base
{
    public class BaseProductDto
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string PictureUrl { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
    }
}
