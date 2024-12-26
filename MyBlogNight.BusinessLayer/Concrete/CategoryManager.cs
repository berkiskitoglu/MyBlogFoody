﻿using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.BLRepositories;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class CategoryManager : BLGenericRepositories<Category> , ICategoryService
    {
        public CategoryManager(BlogContext context) : base(context)
        {
        }
    }
}