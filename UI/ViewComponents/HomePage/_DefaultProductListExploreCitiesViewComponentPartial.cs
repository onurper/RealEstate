using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultProductListExploreCitiesViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}