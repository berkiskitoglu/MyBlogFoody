using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.EntityLayer.Concrete
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string Detail { get; set; }
     
        public List<Comment> Comments { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
