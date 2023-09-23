using Api.Dtos.TestimonialDtos;

namespace Api.Repositories.TestimonialRep
{
    public interface ITestimonialRep
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}