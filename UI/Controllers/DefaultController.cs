using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}