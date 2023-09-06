using Api.Dtos.BottomGridDtos;

namespace Api.Repositories.BottomGridRep
{
    public interface IBottomGridRep
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();

        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);

        void DeleteBottomGrid(int id);

        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);

        Task<GetByIdBottomDto> GetBottomGrid(int id);
    }
}