using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult MyCommentList()
        {
          var values =  _commentService.TGetAll();
            return View(values);
        }
 
        [HttpGet]
        public IActionResult AddComment()
        {
          

            return View();
          
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {

            comment.CreatedDate = DateTime.Now;
            comment.Status = true;
            _commentService.TInsert(comment);
            return RedirectToAction("MyCommentList");
        }
        public IActionResult DeleteComment(int id)
        {

            _commentService.TDelete(id);
            return RedirectToAction("MyCommentList");
        }
        [HttpGet]
        public IActionResult UpdateComment(int id)
        {

            var values = _commentService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentService.TUpdate(comment);
            return RedirectToAction("MyCommentList");
        }
    }
}
