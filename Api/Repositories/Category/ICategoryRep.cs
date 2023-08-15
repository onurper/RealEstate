using Api.Dtos.CategoryDtos;

namespace Api.Repositories.Category
{
    public interface ICategoryRep
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task<ResultCategoryDto> GetByIdCategory(int id);
        Task<int> CreateCategory(CreateCategoryDto categoryDto);
        Task<int> UpdateCategory(UpdateCategoryDto categoryDto);
        Task<int> DeleteCategory(int id);
    }
}