using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSideBarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}