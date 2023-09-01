using Api.Repositories.Category;
using Api.Repositories.ServiceRep;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRep _serviceRep;

        public ServicesController(IServiceRep serviceRep)
        {
            _serviceRep = serviceRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetServiceList()
        {
            var values = await _serviceRep.GetAllServiceAsync();
            return Ok(values);
        }
    }
}
