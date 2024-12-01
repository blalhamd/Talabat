namespace Talabat.DataAccess.Repositories.NonGeneric
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(AppDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
