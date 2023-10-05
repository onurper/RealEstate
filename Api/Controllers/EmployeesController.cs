using Api.Dtos.EmployeeDtos;
using Api.Repositories.EmployeeRep;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRep _employeeRep;

        public EmployeesController(IEmployeeRep employeeRep)
        {
            _employeeRep = employeeRep;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRep.GetAllEmployeeAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEmployee(int id)
        {
            var values = await _employeeRep.GetByIdEmployeeAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto employeeDto)
        {
            var values = await _employeeRep.CreateEmployeeAsync(employeeDto);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var values = await _employeeRep.DeleteEmployeeAsync(id);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto employeeDto)
        {
            var values = await _employeeRep.UpdateEmployeeAsync(employeeDto);
            return Ok(values);
        }
    }
}
