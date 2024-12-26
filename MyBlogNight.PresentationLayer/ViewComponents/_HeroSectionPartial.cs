using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _HeroSectionPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _HeroSectionPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            //var values = _articleService.ArticleListWithTagClouds();
            //return View(values);
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }
    }
}
