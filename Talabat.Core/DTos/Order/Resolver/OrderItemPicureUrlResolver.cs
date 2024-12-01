namespace Talabat.Core.DTos.Order.Resolver
{
    public class OrderItemPicureUrlResolver : IValueResolver<OrderItem, OrderItemDto, string>
    {
        private readonly IConfiguration _configuration;

        public OrderItemPicureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.Product.PictureUrl) && source is not null)
            {
                var FullPath = _configuration["BaseURI"] + source.Product.PictureUrl;

                return FullPath;
            }

            return null!;
        }
    }
}
