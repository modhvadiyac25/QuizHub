using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using QuizHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Controllers
{
   
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public UserController(IUserRepository userRepo,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _userRepo = userRepo;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        /*
                public IActionResult Index()
                {
                    return View();
                }
        */
        /*
                [AcceptVerbs("Get","Post")]
                [AllowAnonymous]
                public async Task<IActionResult> IsEmainInUse(string email)
                {
                    var user = await userManager.FindByEmailAsync(email);

                    if (user == null)
                    {
                        return Json(true);
                    }
                    else
                    {
                        return Json($"Email {email} is already in use");
                    }
                }
                */

        [HttpPost]
        public async Task<IActionResult> logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index","Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password,model.RememberMe, false);
               
                if (result.Succeeded )
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("index", "Home");
                    }

                }
                

                ModelState.AddModelError(string.Empty,"Invalide login !!");
                
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userOfModel = new User
                {
                    fname = model.fname,
                    lname = model.lname,
                    email=model.email,
                    mno=model.mno,
                    password=model.password

                };
                var user = new IdentityUser
                {
                    UserName = model.email,
                    Email = model.email
                };

                var result = await userManager.CreateAsync(user,model.password);
                _userRepo.Add(userOfModel);

                if (result.Succeeded)
                {

                    if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Administration");
                    }

                    await signInManager.SignInAsync(user,isPersistent:false);
                    return RedirectToAction("index","Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty,error.Description);
                }

            }
            return View(model);
        }
    }
}