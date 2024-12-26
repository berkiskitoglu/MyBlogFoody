using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _CategoryTilePartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _CategoryTilePartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }
    }
}
