using Api.Repositories.ServiceRep;
using Api.Repositories.StatisticsRep;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRep statisticsRep;

        public StatisticsController(IStatisticsRep statisticsRep)
        {
            this.statisticsRep = statisticsRep;
        }

        [HttpGet("ActiveCategoryCountAsync")]
        public async Task<IActionResult> ActiveCategoryCountAsync()
        {
            var values = await statisticsRep.ActiveCategoryCountAsync();
            return Ok(values);
        }


        [HttpGet("ActiveEmployeeCountAsync")]
        public async Task<IActionResult> ActiveEmployeeCountAsync()
        {
            var values = await statisticsRep.ActiveEmployeeCountAsync();
            return Ok(values);
        }


        [HttpGet("ApartmentCountAsync")]
        public async Task<IActionResult> ApartmentCountAsync()
        {
            var values = await statisticsRep.ApartmentCountAsync();
            return Ok(values);
        }

        [HttpGet("AvgProductPriceByRentAsync")]
        public async Task<IActionResult> AvgProductPriceByRentAsync()
        {
            var values = await statisticsRep.AvgProductPriceByRentAsync();
            return Ok(values);
        }

        [HttpGet("AvgProductPriceBySaleAsync")]
        public async Task<IActionResult> AvgProductPriceBySaleAsync()
        {
            var values = await statisticsRep.AvgProductPriceBySaleAsync();
            return Ok(values);
        }

        [HttpGet("CategoryCountAsync")]
        public async Task<IActionResult> CategoryCountAsync()
        {
            var values = await statisticsRep.CategoryCountAsync();
            return Ok(values);
        }


        [HttpGet("CategoryNameByMaxProductCountAsync")]
        public async Task<IActionResult> CategoryNameByMaxProductCountAsync()
        {
            var values = await statisticsRep.CategoryNameByMaxProductCountAsync();
            return Ok(values);
        }

        [HttpGet("CityNameByMaxProductCountAsync")]
        public async Task<IActionResult> CityNameByMaxProductCountAsync()
        {
            var values = await statisticsRep.CityNameByMaxProductCountAsync();
            return Ok(values);
        }
    }
}
