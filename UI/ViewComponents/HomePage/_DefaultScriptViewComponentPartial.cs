using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultScriptViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
