using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultFeatureViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}