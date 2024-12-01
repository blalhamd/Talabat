namespace Talabat.API.Controllers
{
    public class PaymentsController : ApiBaseController
    {
        private readonly IPayementService _payementService;

        public PaymentsController(IPayementService payementService)
        {
            _payementService = payementService;
        }

        [Authorize]
        [HttpPost("{basketId}")]
        public async Task<BasketDto> CreateOrUpdatePaymentIntent(string basketId)
        {
            return await _payementService.CreateOrUpdatePaymentIntent(basketId);
        }
    }
}
