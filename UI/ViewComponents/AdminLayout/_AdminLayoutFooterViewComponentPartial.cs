using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}