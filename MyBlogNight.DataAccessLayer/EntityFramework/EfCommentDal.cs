using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {
        }

        public List<Comment> GetComentsByAppUserID(int id)
        {
            throw new NotImplementedException();
        }

        //public List<Comment> GetComentsByAppUserID(int id)
        //{
        //    var context = new BlogContext();
        //    context.Comments.Include(x=>x.AppUser)
        //}

        public List<Comment> GetCommentsByAppUserID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
