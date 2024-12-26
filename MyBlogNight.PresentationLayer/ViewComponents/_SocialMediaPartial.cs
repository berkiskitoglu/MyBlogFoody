using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _SocialMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialMediaPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var socialMediaList = _socialMediaService.TGetAll();
            return View(socialMediaList);
        }
    }
}
