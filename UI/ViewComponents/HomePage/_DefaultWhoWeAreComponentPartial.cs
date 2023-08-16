using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
