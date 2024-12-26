using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.BLRepositories;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class ArticleManager : BLGenericRepositories<Article> , IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(BlogContext context, IArticleDal articleDal) : base(context)
        {
            _articleDal = articleDal;
        }

     

        public List<Article> TArticleListWithCategory()
        {
            return _articleDal.ArticleListWithCategory();
        }

        public List<Article> TArticleListWithCategoryAndAppUser()
        {
            return _articleDal.ArticleListWithCategoryAndAppUser();
        }

        public Article TArticleListWithCategoryAndAppUserByArticleID(int id)
        {
            return _articleDal.ArticleListWithCategoryAndAppUserByArticleID(id);
        }
    }
}
