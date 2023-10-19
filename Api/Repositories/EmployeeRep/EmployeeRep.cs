using Api.Dtos.EmployeeDtos;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.EmployeeRep
{
    public class EmployeeRep : IEmployeeRep
    {
        private readonly Context _context;

        public EmployeeRep(Context context)
        {
            _context = context;
        }

        public async Task<int> CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto)
        {
            string query = @"INSERT INTO Employee (Name, Title, Mail, PhoneNumber, ImageUrl, Status) VALUES (@Name, @Title, @Mail, @PhoneNumber, @ImageUrl, @Status)";

            var parameters = new DynamicParameters();
            parameters.Add("@Name", createEmployeeDto.Name);
            parameters.Add("@Title", createEmployeeDto.Title);
            parameters.Add("@Mail", createEmployeeDto.Mail);
            parameters.Add("@PhoneNumber", createEmployeeDto.PhoneNumber);
            parameters.Add("@ImageUrl", createEmployeeDto.ImageUrl);
            parameters.Add("@Status", true);

            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var result = await connection.ExecuteAsync(query, parameters);
                    return result;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            string query = @"DELETE FROM Employee WHERE EmployeeId = @EmployeeId";
            var parameter = new DynamicParameters();
            parameter.Add("@EmployeeId", id);

            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var result = await connection.ExecuteAsync(query, parameter);
                    return result;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = @"SELECT  [EmployeeId]
      ,[Name]
      ,[Title]
      ,[Mail]
      ,[PhoneNumber]
      ,[ImageUrl]
      ,[Status]
  FROM [DbDapperRealEstate].[dbo].[Employee]";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdEmployeeDto> GetByIdEmployeeAsync(int id)
        {
            string query = @"SELECT  [EmployeeId]
      ,[Name]
      ,[Title]
      ,[Mail]
      ,[PhoneNumber]
      ,[ImageUrl]
      ,[Status]
  FROM [DbDapperRealEstate].[dbo].[Employee] WHERE EmployeeId = @EmployeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", id);
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var values = await connection.QueryFirstAsync<GetByIdEmployeeDto>(query, parameters);
                    return values;
                }
            }
            catch (Exception)
            {
                return Enumerable.Empty<GetByIdEmployeeDto>().FirstOrDefault();
            }
        }

        public async Task<int> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = @"UPDATE Employee SET Name = @Name, Title = @Title, Mail = @Mail, PhoneNumber = @PhoneNumber, ImageUrl = @ImageUrl, Status = @Status WHERE EmployeeId = @EmployeeId";
            var parameter = new DynamicParameters();
            parameter.Add("@Name", updateEmployeeDto.Name);
            parameter.Add("@Title", updateEmployeeDto.Title);
            parameter.Add("@Mail", updateEmployeeDto.Mail);
            parameter.Add("@PhoneNumber", updateEmployeeDto.PhoneNumber);
            parameter.Add("@ImageUrl", updateEmployeeDto.ImageUrl);
            parameter.Add("@Status", updateEmployeeDto.Status);
            parameter.Add("@EmployeeId", updateEmployeeDto.EmployeeId);

            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var result = await connection.ExecuteAsync(query, parameter);
                    return result;
                }
            }
            catch (Exception Ex)
            {
                return -1;
            }
        }
    }
}