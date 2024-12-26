﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Areas.Writer.Models;

namespace MyBlogNight.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if(result.Succeeded)
            {
                return RedirectToAction("CategoryList", "Category", new {area="Admin"});
            }
            else
            {
                return View();
            }
            
        }
    }
}