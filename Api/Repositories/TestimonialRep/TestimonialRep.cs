using Api.Dtos.TestimonialDtos;
using Api.Models.DapperContext;
using Dapper;

namespace Api.Repositories.TestimonialRep
{
    public class TestimonialRep : ITestimonialRep
    {
        private readonly Context _context;

        public TestimonialRep(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = @"SELECT [Id]
      ,[NameSurname]
      ,[Title]
      ,[Comment]
      ,[Status]
  FROM [DbDapperRealEstate].[dbo].[Testimonial]";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }
    }
}