using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}