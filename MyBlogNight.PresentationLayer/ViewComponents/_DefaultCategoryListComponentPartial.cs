using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultCategoryListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultCategoryListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

     
        public IViewComponentResult Invoke()
        {
            var categoryList = _articleService.TArticleListWithCategory();
            return View(categoryList);
        }
    }
    }

