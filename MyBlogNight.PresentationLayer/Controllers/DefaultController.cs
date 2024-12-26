using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IAboutService _aboutService;
        public DefaultController(IArticleService articleService, IAboutService aboutService)
        {
            _articleService = articleService;
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MainCourses()
        {
            var values = _articleService.TArticleListWithCategory().Where(x => x.CategoryID == 1).ToList();
            return View(values);
        }
        public IActionResult Desserts()
        {
            var values = _articleService.TArticleListWithCategory().Where(x => x.CategoryID == 2).ToList();
            return View(values);
        }
        public IActionResult Breakfast()
        {
            var values = _articleService.TArticleListWithCategory().Where(x => x.CategoryID == 3).ToList();
            return View(values);
        }
        public IActionResult Beverages()
        {
            var values = _articleService.TArticleListWithCategory().Where(x => x.CategoryID == 4).ToList();
            return View(values);
        }
        public IActionResult Salads()
        {
            var values = _articleService.TArticleListWithCategory().Where(x => x.CategoryID == 6).ToList();
            return View(values);
        }

      public IActionResult About()
        {
            var values = _aboutService.TGetAll();
            return View(values);
        }
    }
}
