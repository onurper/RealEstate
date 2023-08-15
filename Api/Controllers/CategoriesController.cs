using Api.Dtos.CategoryDtos;
using Api.Repositories.Category;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRep _categoryRep;

        public CategoriesController(ICategoryRep categoryRep)
        {
            _categoryRep = categoryRep;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRep.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCategory(int id)
        {
            var values = await _categoryRep.GetByIdCategory(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            var values = await _categoryRep.CreateCategory(categoryDto);
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var values = await _categoryRep.DeleteCategory(id);
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> DeleteCategory(UpdateCategoryDto categoryDto)
        {
            var values = await _categoryRep.UpdateCategory(categoryDto);
            return Ok(values);
        }
    }
}
