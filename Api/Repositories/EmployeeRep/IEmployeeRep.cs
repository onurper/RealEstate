using Api.Dtos.EmployeeDtos;

namespace Api.Repositories.EmployeeRep
{
    public interface IEmployeeRep
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();

        Task<GetByIdEmployeeDto> GetByIdEmployeeAsync(int id);

        Task<int> CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto);

        Task<int> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);

        Task<int> DeleteEmployeeAsync(int id);
    }
}
