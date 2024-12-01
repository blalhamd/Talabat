namespace Talabat.Core.AutoMapper.Resolvers
{
    public class ProductImageUrlResolver : IValueResolver<Product, ProductResponse, string>
    {
        private readonly IConfiguration _configuration;

        public ProductImageUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(Product source, ProductResponse destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _configuration["BaseURI"] + source.PictureUrl;
            }
            else 
               return string.Empty;
        }
    }
}
