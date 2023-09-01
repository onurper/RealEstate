using Api.Dtos.WhoWeAreDetailDtos;
using Api.Repositories.WhoWeAreRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRep _whoWeAreDetailRep;

        public WhoWeAreDetailController(IWhoWeAreDetailRep whoWeAreDetailRep)
        {
            _whoWeAreDetailRep = whoWeAreDetailRep;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRep.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdWhoWeAreDetail(int id)
        {
            var values = await _whoWeAreDetailRep.GetWhoWeAreDetail(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWhoWeAreDetail(CreateWhoWeAreDetailDto create)
        {
            _whoWeAreDetailRep.CreateWhoWeAreDetail(create);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreDetailRep.DeleteWhoWeAreDetail(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult DeleteWhoWeAreDetail(UpdateWhoWeAreDetailDto update)
        {
            _whoWeAreDetailRep.UpdateWhoWeAreDetail(update);
            return Ok();
        }
    }
}
