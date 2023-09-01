using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultSubFeatureViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}