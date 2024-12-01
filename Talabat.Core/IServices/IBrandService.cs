namespace Talabat.Core.IServices
{
    public interface IBrandService
    {
        Task<IList<BrandResponse>> GetBrands();
        Task<BrandResponse> GetBrandById(int id);
    }
}
