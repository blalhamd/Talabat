namespace Talabat.Core.DTos.Product.Responses
{
    public class ProductResponse : BaseProductDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string ProductTypeName { get; set; } = null!;
    }
}
