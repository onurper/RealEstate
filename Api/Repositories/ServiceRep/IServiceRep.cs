using Api.Dtos.ServiceDtos;

namespace Api.Repositories.ServiceRep
{
    public interface IServiceRep
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createWhoWeAreDetailDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateWhoWeAreDetailDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
