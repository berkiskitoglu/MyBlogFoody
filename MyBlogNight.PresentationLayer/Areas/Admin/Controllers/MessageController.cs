using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IContactService _contactService;

        public MessageController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Inbox()
        {
            var values = _contactService.TGetAll();
            return View(values);
        }
    }
}
