using Api.Dtos.EmployeeDtos;

namespace Api.Repositories.EmployeeRep
{
    public interface IEmployeeRep
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();

        Task<GetByIdEmployeeDto> GetByIdEmployee(int id);

        Task<int> CreateEmployee(CreateEmployeeDto createEmployeeDto);

        Task<int> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);

        Task<int> DeleteEmployee(int id);
    }
}
