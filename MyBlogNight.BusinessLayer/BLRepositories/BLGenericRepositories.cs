using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.BLRepositories
{
    public class BLGenericRepositories<T> : IGenericService<T> where T : class
    {
        private readonly BlogContext _context;

        public BLGenericRepositories(BlogContext context)
        {
            _context = context;
        }

        public void TDelete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public List<T> TGetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T TGetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void TInsert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void TUpdate(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
