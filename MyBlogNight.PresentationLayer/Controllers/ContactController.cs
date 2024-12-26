using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.SendDate = DateTime.Now;
            contact.Status = true;
            if (ModelState.IsValid)
            {
                _contactService.TInsert(contact); // Mesajı kaydediyoruz
               
                ViewBag.Message = "Mesajınız başarıyla gönderildi!";
                return View(); // Başarıyla gönderildikten sonra aynı sayfaya dönüyoruz
            }
            ViewBag.Message = "Mesaj gönderilemedi. Lütfen tekrar deneyin.";
            return RedirectToAction("Index"); // Hatalı form durumu
        }
    }
}
