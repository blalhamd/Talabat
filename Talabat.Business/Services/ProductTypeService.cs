namespace Talabat.Business.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IUnitOfWork<ProductType> _unitOfWork;
        private readonly IMapper _mapper;

        public ProductTypeService(IUnitOfWork<ProductType> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IList<ProductTypeResponse>> GetProductTypes()
        {

            var ProductTypes = await _unitOfWork.RepositoryAsync.GetAllAsync();

            if (ProductTypes is null)
            {
                throw new ItemNotFound("No Exist ProductTypes");
            }

            var models = _mapper.Map<List<ProductTypeResponse>>(ProductTypes);

            return models;
        }

        public async Task<ProductTypeResponse> GetProductTypeById(int id)
        {

            var ProductType = await _unitOfWork.RepositoryAsync.GetByIdAsync(id);

            if (ProductType is null)
            {
                throw new ItemNotFound($"No Exist ProductType with This Id: {id}");
            }

            var model = _mapper.Map<ProductTypeResponse>(ProductType);

            return model;
        }
    }
}
