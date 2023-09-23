using Api.Dtos.EmployeeDtos;
using Api.Models.DapperContext;

namespace Api.Repositories.EmployeeRep
{
    public class EmployeeRep : IEmployeeRep
    {
        private readonly Context _context;

        public EmployeeRep(Context context)
        {
            _context = context;
        }

        public Task<int> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdEmployeeDto> GetByIdEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
