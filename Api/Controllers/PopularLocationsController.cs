using Api.Repositories.PopulerLocationRep;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRep _popularLocationRep;

        public PopularLocationsController(IPopularLocationRep popularLocationRep)
        {
            _popularLocationRep = popularLocationRep;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRep.GetAllPopularLocationAsync();
            return Ok(values);
        }
    }
}