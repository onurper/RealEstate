using Api.Dtos.ServiceDtos;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.ServiceRep
{
    public class ServiceRep : IServiceRep
    {
        private readonly Context _context;

        public ServiceRep(Context context)
        {
            _context = context;
        }

        public void CreateService(CreateServiceDto createWhoWeAreDetailDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = @"SELECT [ServiceId]
      ,[Name]
      ,[Status]
  FROM [DbDapperRealEstate].[dbo].[Service]";
            using (var con = _context.CreateConnection())
            {
                var value = await con.QueryAsync<ResultServiceDto>(query);
                return value.ToList();
            }
        }

        public Task<GetByIdServiceDto> GetService(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(UpdateServiceDto updateWhoWeAreDetailDto)
        {
            throw new NotImplementedException();
        }
    }
}