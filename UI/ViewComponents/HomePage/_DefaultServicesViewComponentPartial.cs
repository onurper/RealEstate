using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultServicesViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
