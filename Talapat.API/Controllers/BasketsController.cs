namespace Talabat.API.Controllers
{
	[EnableRateLimiting(policyName: RateLimiterType.Concurrency)]
	public class BasketsController : ApiBaseController
    {
        private readonly IBasketService _BasketService;

        public BasketsController(IBasketService basketService)
        {
            _BasketService = basketService;
        }

        [HttpGet("{BasketId}")]
        [HasPermission(Permissions.GetBasketById)]
        public async Task<BasketDto> Get(string BasketId)
        {
           return await _BasketService.GetBasket(BasketId);
        }

        [HttpPost]
        [HasPermission(Permissions.AddBasket)]
        public async Task<ActionResult<BasketDto>> Create(UpdateBasketRequest basket)
        {
            return await _BasketService.UpdateBasket(basket);
        }


        [HttpPut]
        [HasPermission(Permissions.EditBasket)]
        public async Task<ActionResult<BasketDto?>> Update(UpdateBasketRequest basket)
        {
            return await _BasketService.UpdateBasket(basket);
        }

        [HttpDelete("{BasketId}")]
        [HasPermission(Permissions.DeleteBasket)]
        public async Task<bool> Delete(string BasketId)
        {
            return await _BasketService.DeleteBasket(BasketId);
        }


    }
}
