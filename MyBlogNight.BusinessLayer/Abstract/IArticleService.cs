﻿using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public List<Article> TArticleListWithCategory();

        List<Article> TArticleListWithCategoryAndAppUser();
        public Article TArticleListWithCategoryAndAppUserByArticleID(int id);
    }
}
