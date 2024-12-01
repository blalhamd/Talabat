namespace Talabat.API.Controllers
{
	[Cached(duration: 30)]
	[EnableRateLimiting(policyName: RateLimiterType.Concurrency)]
	public class ProductsController : ApiBaseController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [HasPermission(Permissions.GetAllProducts)]
        [ProducesResponseType(typeof(IList<ProductResponse>),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<ProductResponse>>> Get([FromQuery]ProductsSpecParam productsSpec, [FromQuery] Sorting<Product> sorting = null)
        {
            return Ok(await _productService.GetAllProducts(productsSpec.BrandId, productsSpec.ProductTypeId, productsSpec.pagination, sorting));
        }

        [HttpGet("{id}")]
        [HasPermission(Permissions.GetProductById)]
        [ProducesResponseType(typeof(ProductResponse),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductResponse>> GetByid(int id)
        {
            return Ok(await _productService.GetProductById(id));
        }

        [HttpPost]
        [HasPermission(Permissions.AddProduct)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ValidationErrorCustomResponse),StatusCodes.Status400BadRequest)]
        public async Task AddProduct(CreateProductRequest viewModel)
        {
            await _productService.AddProductAsync(viewModel);
        }

        [HttpPut]
        [HasPermission(Permissions.EditProduct)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationErrorCustomResponse),StatusCodes.Status400BadRequest)]
        public async Task UpdateProduct(int id, CreateProductRequest model)
        {
            await _productService.UpdateProductAsync(id, model);
        }

        [HttpDelete("{id}")]
        [HasPermission(Permissions.DeleteProduct)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationErrorCustomResponse),StatusCodes.Status400BadRequest)]
        public async Task DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);
        }


    }
}
