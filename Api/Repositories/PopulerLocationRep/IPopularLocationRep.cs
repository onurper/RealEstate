using Api.Dtos.PopularLocationDto;

namespace Api.Repositories.PopulerLocationRep
{
    public interface IPopularLocationRep
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}