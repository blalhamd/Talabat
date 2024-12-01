namespace Talabat.Core.IServices
{
    public interface IProductTypeService
    {
        Task<IList<ProductTypeResponse>> GetProductTypes();
        Task<ProductTypeResponse> GetProductTypeById(int id);
    }
}
