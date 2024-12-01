namespace Talabat.API.Controllers
{
	[Cached(duration: 600)]
	[EnableRateLimiting(policyName: RateLimiterType.Concurrency)]
	public class ProductTypesController : ApiBaseController
    {
        private readonly IProductTypeService _ProductTypeService;

        public ProductTypesController(IProductTypeService ProductTypeService)
        {
            _ProductTypeService = ProductTypeService;
        }

        [HttpGet]
        [HasPermission(Permissions.GetAllProductTypes)]
        [ProducesResponseType(typeof(ProductTypeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<ProductTypeResponse>>> GetAll()
        {
            return Ok(await _ProductTypeService.GetProductTypes());
        }

        [HttpGet("{id}")]
        [HasPermission(Permissions.GetProductTypeById)]
        [ProducesResponseType(typeof(ProductTypeResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationErrorCustomResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductTypeResponse>> GetById(int id)
        {
            return Ok(await _ProductTypeService.GetProductTypeById(id));
        }
    }
}
