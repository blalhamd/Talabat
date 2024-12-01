namespace Talabat.Business.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _repository;
        private readonly IMapper _mapper;
        public BasketService(IBasketRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BasketDto> GetBasket(string BasketId)
        {
            var basket = await _repository.GetBasketAsync(BasketId);

            if(basket is null)
            {
               return new BasketDto();
            }

            var basketDto = _mapper.Map<BasketDto>(basket);

            return basketDto;
        }

        public async Task<BasketDto> UpdateBasket(UpdateBasketRequest basketDto)
        {
            var basket = _mapper.Map<Basket>(basketDto);

            var CreatedOrUpdated = await _repository.UpdateBasketAsync(basket);

            if (CreatedOrUpdated is null)
                throw new BadRequest("data is null");

            var response = _mapper.Map<BasketDto>(CreatedOrUpdated);

            return response;
        }

        public async Task<bool> DeleteBasket(string BasketId)
        {
            var basket = await _repository.GetBasketAsync(BasketId);

            if (basket is null)
                throw new BadRequest("This Basket is not found");

            return await _repository.DeleteBasketAsync(BasketId);
        }
    }
}
