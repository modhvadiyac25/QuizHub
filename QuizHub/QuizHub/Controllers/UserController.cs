using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepo.Add(user);
                ViewData["succes"] = "registration succesfully !!";
            }
            else
            {
                ViewData["fail"] = "Please enter the valide data !!";
            }
            return View();
        }

        [HttpGet]
        public ViewResult login()
        {
            return View();
        }
    }
}
