namespace Talabat.Core.DTos.Product.Requests
{
    public class CreateProductRequest : BaseProductDto
    {
        [Required]
        public int BrandId { get; set; }
        [Required]
        public int ProductTypeId { get; set; }
    }
}
