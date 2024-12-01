namespace Talabat.Business.Services
{
    public class PayementService : IPayementService
    {
        private readonly IConfiguration _configuration;
        private readonly IBasketService _basketService;
        private readonly IUnitOfWork<BaseEntity> _unitOfWork;
        private readonly IMapper _mapper;
        public PayementService(IConfiguration configuration, IBasketService basketService, IUnitOfWork<BaseEntity> unitOfWork, IMapper mapper)
        {
            _configuration = configuration;
            _basketService = basketService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BasketDto> CreateOrUpdatePaymentIntent(string basketId)
        {
            StripeConfiguration.ApiKey = _configuration["StripeSettings:SecretKey"];

            var basket = await _basketService.GetBasket(basketId);

            decimal shippingPrice = 0m;
            
            if(basket.DeliveryMethodId.HasValue)
            {
                var deliveryMethod = await _unitOfWork.DeliveryMethodRepositoryAsync.GetByIdAsync(basket.DeliveryMethodId.Value);

                basket.ShippingCost = deliveryMethod.Cost;
                shippingPrice = deliveryMethod.Cost;
            }

            if(basket?.Items?.Count > 0)
            {
                foreach (var item in basket.Items)
                {
                    var product = await _unitOfWork.ProductRepository.GetByIdAsync(item.Id);

                    if(product.Price != item.Price)
                      item.Price = product.Price;
                }
            }

            var service = new PaymentIntentService();

            PaymentIntent paymentIntent; 

            if (string.IsNullOrEmpty(basket!.PaymentIntentId))
            {
                var paymentIntentCreateOptions = new PaymentIntentCreateOptions()
                {
                    Amount = (long)(basket.Items.Sum(i => i.Price * i.Quantity * 100) + shippingPrice * 100),
                    Currency = "usd",
                    PaymentMethodTypes = new List<string> { "card" }
                };

                paymentIntent = await service.CreateAsync(paymentIntentCreateOptions);

                basket.PaymentIntentId = paymentIntent.Id;
                basket.ClientSecret = paymentIntent.ClientSecret;
            }
            else
            {
                var paymentIntentUpdateOptions = new PaymentIntentUpdateOptions()
                {
                    Amount = (long)(basket.Items.Sum(i => i.Price * i.Quantity * 100) + shippingPrice * 100),
                };

                await service.UpdateAsync(basket.PaymentIntentId,paymentIntentUpdateOptions);
            }

            var updatedBasket = _mapper.Map<UpdateBasketRequest>(basket);

            return await _basketService.UpdateBasket(updatedBasket);
        }
    }
}
