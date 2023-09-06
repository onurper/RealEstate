using Api.Dtos.PopularLocationDto;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.PopulerLocationRep
{
    public class PopularLocationRep : IPopularLocationRep
    {
        private readonly Context _context;

        public PopularLocationRep(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = @"SELECT [Id]
      ,[CityName]
      ,[ImageUrl]
  FROM [DbDapperRealEstate].[dbo].[PopularLocation]";
            using (var con = _context.CreateConnection())
            {
                var value = await con.QueryAsync<ResultPopularLocationDto>(query);
                return value.ToList();
            }
        }
    }
}