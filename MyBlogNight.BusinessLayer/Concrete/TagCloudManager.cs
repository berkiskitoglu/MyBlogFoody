using MyBlogNight.BusinessLayer.Abstract;
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
    public class TagCloudManager : BLGenericRepositories<TagCloud>,ITagCloudService
    {
        public TagCloudManager(BlogContext context) : base(context)
        {
        }
    }
}
