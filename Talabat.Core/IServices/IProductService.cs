namespace Talabat.Core.IServices
{
    public interface IProductService
    {
        Task<IList<ProductResponse>> GetAllProducts(int? BrandId, int? ProductTypeId,Pagination pagination = null,Sorting<Product> sorting = null);
        Task<ProductResponse> GetProductById(int id);
        Task AddProductAsync(CreateProductRequest product);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(int id,CreateProductRequest product);
    }
}
