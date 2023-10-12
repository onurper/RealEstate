using Api.Dtos.EmployeeDtos;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.StatisticsRep
{
    public class StatisticsRep : IStatisticsRep
    {
        private readonly Context _context;

        public StatisticsRep(Context context)
        {
            _context = context;
        }

        public async Task<int> ActiveCategoryCountAsync()
        {
            string query = @"SELECT Count(*)
  FROM [DbDapperRealEstate].[dbo].[Category]
  WHERE CategoryStatus = 1";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<int> ActiveEmployeeCountAsync()
        {
            string query = @"SELECT COUNT(*)
  FROM [DbDapperRealEstate].[dbo].[Employee]
  WHERE Status = 1";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<int> ApartmentCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<decimal> AvgProductPriceByRentAsync()
        {
            string query = @"SELECT AVG(Price)
FROM [Product]
WHERE Type = 'Kiralık'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<decimal> AvgProductPriceBySaleAsync()
        {
            string query = @"SELECT AVG(Price)
FROM [Product]
WHERE Type = 'Satılık'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<int> AvgRoomCountAsync()
        {
            string query = @"SELECT AVG(RoomCount)
FROM ProductDetails";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<int> CategoryCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<string> CategoryNameByMaxProductCountAsync()
        {
            string query = @"SELECT TOP 1 CategoryName
FROM Product p
INNER JOIN Category c
	ON c.CategoryId = p.ProductCategoryId
GROUP BY CategoryName
ORDER BY COUNT(ProductCategoryId) DESC";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<string>(query);
                return values;
            }
        }

        public async Task<string> CityNameByMaxProductCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<string>(query);
                return values;
            }
        }

        public async Task<int> DiffCityCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<string> EmployeeNameByMaxProductCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<string>(query);
                return values;
            }
        }

        public async Task<decimal> LastProductPriceAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<decimal>(query);
                return values;
            }
        }

        public async Task<string> NewestBuildingYearAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<string>(query);
                return values;
            }
        }

        public async Task<string> OldestBuildingYearAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<string>(query);
                return values;
            }
        }

        public async Task<int> PassiveCategoryCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }

        public async Task<int> ProductCountAsync()
        {
            string query = @"SELECT COUNT(*)
FROM [DbDapperRealEstate].[dbo].[Product]
WHERE Title LIKE '%Daire%'";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<int>(query);
                return values;
            }
        }
    }
}
