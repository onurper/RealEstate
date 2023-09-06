using Api.Dtos.BottomGridDtos;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.BottomGridRep
{
    public class BottomGridRep : IBottomGridRep
    {
        private readonly Context _context;

        public BottomGridRep(Context context)
        {
            _context = context;
        }

        public void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = @"SELECT [Id]
      ,[Icon]
      ,[Title]
      ,[Description]
  FROM [DbDapperRealEstate].[dbo].[BottomGrid]";
            using (var con = _context.CreateConnection())
            {
                var value = await con.QueryAsync<ResultBottomGridDto>(query);
                return value.ToList();
            }
        }

        public Task<GetByIdBottomDto> GetBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}