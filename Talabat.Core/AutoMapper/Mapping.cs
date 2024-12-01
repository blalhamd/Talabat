namespace Talabat.Core.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Product

            CreateMap<Product, ProductResponse>()
                .ForMember(des=> des.BrandName,option=> option.MapFrom(src=> src.Brand.Name))
                .ForMember(des=> des.ProductTypeName,option=> option.MapFrom(src=> src.ProductType.Name))
                .ForMember(des=> des.PictureUrl,option=> option.MapFrom<ProductImageUrlResolver>())
                .ReverseMap();

            CreateMap<CreateProductRequest,Product>().ReverseMap();

			// Product Types

			CreateMap<ProductType, ProductTypeResponse>().ReverseMap();

            // Brand

            CreateMap<Brand,BrandResponse>().ReverseMap();

            // Address

            CreateMap<AddressDto, DataAccess.Identity.IdentityEntities.Address>().ReverseMap();
            CreateMap<AddressOrderDto, Address>().ReverseMap();

            // Basket

            CreateMap<UpdateBasketRequest, Basket>().ReverseMap();

			CreateMap<Basket, BasketDto>().ReverseMap();

			CreateMap<UpdateBasketRequest, Basket>()
			  .ForMember(des => des.SubTotal, opt => opt.MapFrom(src => src.ShippingCost + src.Items.Sum(x => x.Quantity * x.Price)))
			  .ReverseMap();


			CreateMap<BasketDto, UpdateBasketRequest>().ReverseMap();

			// BasketItem

			CreateMap<BasketItemDto, BasketItem>().ReverseMap();

			// DeliveryMethod

			CreateMap<DeliveryMethod, DeliveryMethodOrderDto>().ReverseMap();
            CreateMap<DeliveryMethod, DeliveryMethodDto>().ReverseMap();

			// OrderItem

			CreateMap<OrderItem,OrderItemDto>()
                .ForMember(des=> des.ProductId,opt=> opt.MapFrom(src=> src.Product.ProductId))
                .ForMember(des=> des.ProductName,opt=> opt.MapFrom(src=> src.Product.ProductName))
                .ForMember(des=> des.PictureUrl,opt=> opt.MapFrom<OrderItemPicureUrlResolver>())
                .ReverseMap();

			// Order

			CreateMap<Order, OrderResponse>();


            // Role
           
            CreateMap<RoleRequest,AppRole>().ReverseMap();

            // User

            CreateMap<UserRequest, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, UserResponse>().ReverseMap();
            CreateMap<UpdateUserProfile, ApplicationUser>().ReverseMap();
        }
    }
}
