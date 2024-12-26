using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Areas.Admin.ViewComponents
{
    public class Head : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
