using Api.Repositories.StatisticsRep;
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

        [HttpGet("DiffCityCountAsync")]
        public async Task<IActionResult> DiffCityCountAsync()
        {
            var values = await statisticsRep.DiffCityCountAsync();
            return Ok(values);
        }

        [HttpGet("EmployeeNameByMaxProductCountAsync")]
        public async Task<IActionResult> EmployeeNameByMaxProductCountAsync()
        {
            var values = await statisticsRep.EmployeeNameByMaxProductCountAsync();
            return Ok(values);
        }

        [HttpGet("LastProductPriceAsync")]
        public async Task<IActionResult> LastProductPriceAsync()
        {
            var values = await statisticsRep.LastProductPriceAsync();
            return Ok(values);
        }

        [HttpGet("NewestBuildingYearAsync")]
        public async Task<IActionResult> NewestBuildingYearAsync()
        {
            var values = await statisticsRep.NewestBuildingYearAsync();
            return Ok(values);
        }

        [HttpGet("OldestBuildingYearAsync")]
        public async Task<IActionResult> OldestBuildingYearAsync()
        {
            var values = await statisticsRep.OldestBuildingYearAsync();
            return Ok(values);
        }

        [HttpGet("PassiveCategoryCountAsync")]
        public async Task<IActionResult> PassiveCategoryCountAsync()
        {
            var values = await statisticsRep.PassiveCategoryCountAsync();
            return Ok(values);
        }

        [HttpGet("ProductCountAsync")]
        public async Task<IActionResult> ProductCountAsync()
        {
            var values = await statisticsRep.ProductCountAsync();
            return Ok(values);
        }
    }
}