namespace Talabat.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork<Order> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        private readonly IPayementService _paymentsService;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrderService(IUnitOfWork<Order> unitOfWork, IMapper mapper, IBasketRepository basketRepository, UserManager<ApplicationUser> userManager, IPayementService paymentsService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _basketRepository = basketRepository;
            _userManager = userManager;
            _paymentsService = paymentsService;
        }

        public async Task<OrderResponse> CreateOrderAsync(string BuyerEmail,CreateOrderRequest request)
        {
            // Get Basket From Basket Repo...

            var basket = await _basketRepository.GetBasketAsync(request.BasketId);

            if (basket is null)
                throw new ItemNotFound("Basket is not exist");

            // Get Items From Basket...

            var orderItems = new List<OrderItem>();

            if (basket?.Items?.Count > 0)
            {
                foreach (var item in basket.Items)
                {
                    var product = await _unitOfWork.ProductRepository.GetByIdAsync(item.Id);

                    orderItems.Add(new OrderItem
                    {
                        Price = product.Price,
                        Qunatity = item.Quantity,
                        Product = new ProudctItemOrdered
                        {
                            PictureUrl = product.PictureUrl,
                            ProductId = product.Id,
                            ProductName = product.Name,
                        }
                    });
                }
            }

            // Get deliveryMethod From Repo...
            
            var deliveryMethod = await _unitOfWork.DeliveryMethodRepositoryAsync.GetByIdAsync(request.DeliveryMethodId);

            if (deliveryMethod is null)
                throw new ItemNotFound("delivery method is not found");

            // Validate if PaymentIntentId is already used..

            var IsExist = await _unitOfWork.OrderRepository.FirstOrDefaultAsync(x => x.PaymentIntentId == basket!.PaymentIntentId);

            if (IsExist is not null)
            {
                await _unitOfWork.OrderRepository.DeleteAsync(basket!.Id);

                await _paymentsService.CreateOrUpdatePaymentIntent(basket!.Id);
            }

            // Create Order
            var address = _mapper.Map<Entities.entities.Order.Address>(request.Address);

            var order = new Order()
            {
                BuyerEmail = BuyerEmail,
                Items = orderItems,
                DeliveryMethod = deliveryMethod,
                SubTotal = orderItems.Select(x => x.Price * x.Qunatity).Sum(),
                PaymentIntentId = basket!.PaymentIntentId,
                ShippingAddress = address,
                DeliveryMethodId = request.DeliveryMethodId
            };

            await _unitOfWork.OrderRepository.AddAsync(order);

            // Save in DB

            await _unitOfWork.SaveAsync();

            var orderResponse = _mapper.Map<OrderResponse>(order);

            return orderResponse;
        }

        public async Task<IList<OrderResponse>> GetOrdersForUserAsync(string BuyerEmail)
        {
            var user = await _userManager.FindByEmailAsync(BuyerEmail);

            if (user is null)
                throw new ItemNotFound("User is not found");

            var spec = new BaseSpecification<Order>()
            {
                Criteria = (x => x.BuyerEmail == BuyerEmail),
                Includes = ["DeliveryMethod", "Items"]
            };

            var orders = await _unitOfWork.OrderRepository.GetAllWithSpecAsync(spec);

            if (orders is null)
                throw new ItemNotFound("not exist orders for that user");

            var orderResponses = _mapper.Map<IList<OrderResponse>>(orders);

            return orderResponses;
        }

        public async Task<OrderResponse> GetOrderByIdAsync(string BuyerEmail, int orderId)
        {
            var user = await _userManager.FindByEmailAsync(BuyerEmail);

            if (user is null)
                throw new ItemNotFound("User is not found");

            var spec = new BaseSpecification<Order>()
            {
                Criteria = (x => x.BuyerEmail == BuyerEmail && x.Id == orderId),
                Includes = ["DeliveryMethod", "Items"]
            };

            var order = await _unitOfWork.OrderRepository.GetByIdWithSpecAsync(spec);

            if (order is null)
                throw new ItemNotFound("not exist order for that user");

            var orderResponse = _mapper.Map<OrderResponse>(order);

            return orderResponse;
        }

        public async Task<IList<DeliveryMethodDto>> GetDeliveryMethodsAsync()
        {
            var deliveryMethods = await _unitOfWork.DeliveryMethodRepositoryAsync.GetAllAsync();

            if (deliveryMethods is null)
                throw new ItemNotFound("Not exist DeliveryMethods");

            var deliveryMethodsDtos = _mapper.Map<IList<DeliveryMethodDto>>(deliveryMethods);

            return deliveryMethodsDtos;
        }
    }
}
