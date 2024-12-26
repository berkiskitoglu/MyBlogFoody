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
    public class CommentManager : BLGenericRepositories<Comment> ,ICommentService
    {
        public CommentManager(BlogContext context) : base(context)
        {
        }
    }
}
