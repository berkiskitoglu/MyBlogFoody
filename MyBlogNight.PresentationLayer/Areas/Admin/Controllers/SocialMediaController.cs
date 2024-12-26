using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.ValidationRules.CategoryValidationRules;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult SocialMediaList()
        {
            var values = _socialMediaService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
                  socialMedia.Status = true;
                _socialMediaService.TInsert(socialMedia);
                return RedirectToAction("SocialMediaList");
         

        }
        public IActionResult DeleteSocialMedia(int id)
        {
            _socialMediaService.TDelete(id);
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = _socialMediaService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            _socialMediaService.TUpdate(socialMedia);
            return RedirectToAction("SocialMediaList");
        }

    }
}
