using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}