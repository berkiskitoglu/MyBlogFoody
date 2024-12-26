using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public ArticleController(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }

        public IActionResult ArticleList()
        {
           var values = _articleService.TArticleListWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddArticle()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                           {
                                              Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                          }).ToList();
            ViewBag.v1 = values1;
            
            return View();
        }
        [HttpPost]
        public IActionResult AddArticle(Article articles)
        {
            articles.CreatedDate = DateTime.Now;
            articles.Status = true;
            articles.AppUserId = 2;
            _articleService.TInsert(articles);
            return RedirectToAction("ArticleList");
        }
        public IActionResult DeleteArticle(int id)
        {
            
            _articleService.TDelete(id);
            return RedirectToAction("ArticleList");
        }
        [HttpGet]
        public IActionResult UpdateArticle(int id)
        {
            
            var values = _articleService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateArticle(Article article)
        {
            article.AppUserId = 2;
            _articleService.TUpdate(article);           
            return RedirectToAction("ArticleList");
        }

    
        
    }
  
}

