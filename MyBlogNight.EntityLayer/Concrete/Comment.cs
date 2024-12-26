using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentDetail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int ArticleID { get; set; }
        public Article article { get; set; }
      
    }
}
