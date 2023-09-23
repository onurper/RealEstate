using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSpinerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}