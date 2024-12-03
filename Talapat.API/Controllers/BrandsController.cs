namespace Talabat.API.Controllers
{
    [Cached(duration: 600)]
    [EnableRateLimiting(policyName: RateLimiterType.Concurrency)]
	public class BrandsController : ApiBaseController
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        [HasPermission(Permissions.GetAllBrands)]
        [ProducesResponseType(typeof(BrandResponse),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse),StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<BrandResponse>>> GetAll()
        {
            return Ok(await _brandService.GetBrands());
        }

        [HttpGet("{id}")]
        [HasPermission(Permissions.GetBrandById)]
        [ProducesResponseType(typeof(BrandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationErrorCustomResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BrandResponse>> GetById(int id)
        {
            return Ok(await _brandService.GetBrandById(id));
        }
    }
}
