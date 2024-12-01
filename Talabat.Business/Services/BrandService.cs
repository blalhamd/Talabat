namespace Talabat.Business.Services
{
    public class BrandService: IBrandService
    {
        private readonly IUnitOfWork<Brand> _unitOfWork;
        private readonly IMapper _mapper;

        public BrandService(IUnitOfWork<Brand> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IList<BrandResponse>> GetBrands()
        {

            var Brands = await _unitOfWork.RepositoryAsync.GetAllAsync();

            if (Brands is null)
            {
                throw new ItemNotFound("No Exist Brands");
            }

            var models = _mapper.Map<List<BrandResponse>>(Brands);

            return models;
        }

        public async Task<BrandResponse> GetBrandById(int id)
        {

            var Brand = await _unitOfWork.RepositoryAsync.GetByIdAsync(id);

            if (Brand is null)
            {
                throw new ItemNotFound($"No Exist Brand with This Id: {id}");
            }

            var model = _mapper.Map<BrandResponse>(Brand);

            return model;
        }
    }
}
