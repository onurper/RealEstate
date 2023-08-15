using Api.Dtos.CategoryDtos;
using Api.Models.DapperContext;
using Dapper;
using System.Xml.Linq;

namespace Api.Repositories.Category
{
    public class CategoryRep : ICategoryRep
    {
        private readonly Context _context;

        public CategoryRep(Context context)
        {
            _context = context;
        }

        public async Task<int> CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = @"INSERT INTO Category (CategoryName, CategoryStatus) VALUES (@CategoryName, @CategoryStatus)";

            var parameters = new DynamicParameters();
            parameters.Add("@CategoryName", categoryDto.CategoryName);
            parameters.Add("@CategoryStatus", true);

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

        public async Task<int> DeleteCategory(int id)
        {
            string query = @"DELETE FROM CATEGORY WHERE CategoryId = @CategoryId";
            var parameter = new DynamicParameters();
            parameter.Add("@CategoryId", id);

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

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = @"SELECT [CategoryId]
          ,[CategoryName]
          ,[CategoryStatus]
        FROM [DbDapperRealEstate].[dbo].[Category]";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultCategoryDto> GetByIdCategory(int id)
        {
            string query = @"SELECT [CategoryId]
          ,[CategoryName]
          ,[CategoryStatus]
        FROM [DbDapperRealEstate].[dbo].[Category] WHERE CategoryId = @CategoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var values = await connection.QueryFirstAsync<ResultCategoryDto>(query, parameters);
                    return values;
                }
            }
            catch (Exception)
            {
                return Enumerable.Empty<ResultCategoryDto>().FirstOrDefault();
            }
           
        }

        public async Task<int> UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = @"UPDATE Category SET CategoryName = @CategoryName, CategoryStatus = @CategoryStatus WHERE CategoryId = @CategoryId";
            var parameter = new DynamicParameters();
            parameter.Add("@CategoryId", categoryDto.CategoryId);
            parameter.Add("@CategoryName", categoryDto.CategoryName);
            parameter.Add("@CategoryStatus", categoryDto.CategoryStatus);

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
    }
}
