namespace Talabat.API.Controllers
{
	[Cached(duration: 600)]
	[EnableRateLimiting(policyName: RateLimiterType.Concurrency)]
	public class OrdersController : ApiBaseController
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
		[HasPermission(Permissions.CreateOrder)]
		[ProducesResponseType(typeof(OrderResponse),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]

        public async Task<OrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            return await _orderService.CreateOrderAsync(email!,request);
        }

        [HttpGet]
		[HasPermission(Permissions.GetOrdersForUser)]
		[ProducesResponseType(typeof(IList<OrderResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse), StatusCodes.Status404NotFound)]
        public async Task<IList<OrderResponse>> GetOrdersForUserAsync()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            return await _orderService.GetOrdersForUserAsync(email!);
        }

		[HttpGet("{orderId}")]
		[HasPermission(Permissions.GetOrderById)]
        [ProducesResponseType(typeof(OrderResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse), StatusCodes.Status404NotFound)]
        public async Task<OrderResponse> GetOrderByIdAsync(int orderId)
        {
            var email = User.FindFirstValue(ClaimTypes.Email);

            return await _orderService.GetOrderByIdAsync(email!, orderId);
        }

		[HttpGet("DeliveryMethods")]
		[HasPermission(Permissions.GetDeliveryMethods)]
        [ProducesResponseType(typeof(IList<DeliveryMethodDto>),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]
        public async Task<IList<DeliveryMethodDto>> GetDeliveryMethodsAsync()
        {
            return await _orderService.GetDeliveryMethodsAsync();
        }
    }
}
