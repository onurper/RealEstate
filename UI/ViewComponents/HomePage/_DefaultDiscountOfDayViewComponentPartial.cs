using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.HomePage
{
    public class _DefaultDiscountOfDayViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}