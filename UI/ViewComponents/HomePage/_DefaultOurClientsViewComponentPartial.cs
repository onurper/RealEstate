using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultOurClientsViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}