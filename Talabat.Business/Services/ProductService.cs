namespace Talabat.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork<Product> _unitOfWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork<Product> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<ProductResponse>> GetAllProducts(int? BrandId, int? ProductTypeId,Pagination pagination = null,Sorting<Product> sorting = null)
        {
            var sort = new Sorting<Product>() { property = sorting.property,IsAsc = sorting.IsAsc};
            var productWithSpecifications = new ProductWithSpecifications(sort);
            productWithSpecifications.Pagination = pagination?? productWithSpecifications.Pagination;
            productWithSpecifications.Criteria =
                (c => !BrandId.HasValue || c.BrandId == BrandId && !ProductTypeId.HasValue || c.ProductTypeId == ProductTypeId);

            var Products = await _unitOfWork.ProductRepository.GetAllWithSpecAsync(productWithSpecifications);

            if (Products is null)
            {
                throw new ItemNotFound("No Exist Products");
            }

            var models = _mapper.Map<List<ProductResponse>>(Products);

            return models;
        }

        public async Task<ProductResponse> GetProductById(int id)
        {

            var productWithSpecifications = new ProductWithSpecifications(x=> x.Id == id);

            var Product = await _unitOfWork.ProductRepository.GetByIdWithSpecAsync(productWithSpecifications);

            if (Product is null)
            {
                throw new ItemNotFound($"No Exist Product with This Id: {id}");
            }

            var model = _mapper.Map<ProductResponse>(Product);

            return model;
        }

        public async Task AddProductAsync(CreateProductRequest model)
        {
            if(model is null)
            {
                throw new BadRequest("data is null"); 
            }

            var checkExist = await _unitOfWork.ProductRepository.FirstOrDefaultAsync(x => x.Name == model.Name &&
                                                 x.Description == model.Description && 
                                                 x.Price == model.Price && 
                                                 x.PictureUrl == model.PictureUrl); 
            if (checkExist is not null)
            {
                throw new ItemAlreadyExist("Item Already Exist"); 
            }

            var product = _mapper.Map<Product>(model);

            await _unitOfWork.ProductRepository.AddAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateProductAsync(int id, CreateProductRequest model)
        {
            if (model is null)
            {
                throw new BadRequest("data is null");
            }

            var product = await _unitOfWork.ProductRepository.GetByIdAsync(id);

            if(product is null)
            {
                throw new ItemNotFound($"No Exist Product with This Id: {id}");
            }

            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.PictureUrl = model.PictureUrl;
            product.BrandId = model.BrandId;
            product.ProductTypeId = model.ProductTypeId;

            await _unitOfWork.ProductRepository.UpdateAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(id);

            if (product is null)
            {
                throw new ItemNotFound($"No Exist Product with This Id: {id}");
            }

            await _unitOfWork.ProductRepository.DeleteAsync(product);
            await _unitOfWork.SaveAsync();
        }


    }
}
