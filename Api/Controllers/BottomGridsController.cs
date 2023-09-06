using Api.Repositories.BottomGridRep;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRep _bottomGridRep;

        public BottomGridsController(IBottomGridRep bottomGridRep)
        {
            _bottomGridRep = bottomGridRep;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRep.GetAllBottomGridAsync();
            return Ok(values);
        }
    }
}