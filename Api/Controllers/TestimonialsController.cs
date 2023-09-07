using Api.Repositories.TestimonialRep;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRep _testimonialRep;

        public TestimonialsController(ITestimonialRep testimonialRep)
        {
            _testimonialRep = testimonialRep;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await _testimonialRep.GetAllTestimonialAsync();
            return Ok(values);
        }
    }
}
