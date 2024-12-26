using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Areas.Admin.Models;
using MyBlogNight.PresentationLayer.Areas.Writer.Models;

namespace MyBlogNight.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProfileController : Controller
    {


        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> UserEdit()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.Email = values.Email;
            userEditViewModel.Username = values.UserName;
            return View(userEditViewModel);

        }
        [HttpPost]
        public async Task<IActionResult>UserEdit(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.Surname;
            user.UserName = userEditViewModel.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("CategoryList", "Category", new {area="Admin"});
            }
            return View();
        }

    }
}
