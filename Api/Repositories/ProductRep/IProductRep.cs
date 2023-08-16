using Api.Dtos.ProductDtos;

namespace Api.Repositories.ProductRep
{
    public interface IProductRep
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
    }
}
