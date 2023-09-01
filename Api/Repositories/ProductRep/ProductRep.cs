using Api.Dtos.ProductDtos;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.ProductRep
{
    public class ProductRep : IProductRep
    {
        private readonly Context _context;

        public ProductRep(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = @"SELECT [ProductId]
      ,[Title]
      ,[Price]
      ,[CoverImage]
      ,[City]
      ,[District]
      ,[Address]
      ,[Description]
      ,[ProductCategoryId]
  FROM [DbDapperRealEstate].[dbo].[Product]";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = @"SELECT P.[ProductId]
      ,P.[Title]
      ,P.[Price]
      ,P.[CoverImage]
      ,P.[City]
      ,P.[District]
	  ,c.[CategoryName]
	  ,p.[Type]
	  ,p.[Address]
  FROM [DbDapperRealEstate].[dbo].[Product] P
  INNER JOIN Category AS C ON C.CategoryId = p.ProductCategoryId";
            //WHERE C.CategoryId = @CategoryId";

            //var parameter = new DynamicParameters();
            //parameter.Add("@CategoryId", );

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}