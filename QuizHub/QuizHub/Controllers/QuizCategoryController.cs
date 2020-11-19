using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizHub.ViewModels;
using QuizHub.Models;

namespace QuizHub.Controllers
{
    // [Authorize(Roles = "User")]
    public class QuizCategoryController : Controller
    {
        private readonly IQuiz_categoryRepository _quiz_CategoryRepository;
        private readonly AppDbContext _context;

        public QuizCategoryController(IQuiz_categoryRepository quiz_CategoryRepository, AppDbContext context)
        {
            this._quiz_CategoryRepository = quiz_CategoryRepository;
            this._context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateCategory(CreateCategoryViewModel model)
        {
            var quiz_category = new Quiz_category
            {
                qc_type = model.Category
            };

            var result = _quiz_CategoryRepository.Add(quiz_category);

            return RedirectToAction("index", "Home");
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PlayQuiz()
        {
            var model = new SelectCategoryViewModel { };

            if (_quiz_CategoryRepository.GetAllCategory() == null)
            {
                ViewBag.ErrorMessage = $" is not found";
                return View("NotFound");
            }

            foreach (var category in _quiz_CategoryRepository.GetAllCategory())
            {
                model.categories.Add(category.qc_type);
            }

            return View(model);

        }

        //  [HttpPost]
        // public IActionResult PlayQuiz()
        // {
        // List<Quiz_category> categoryList = new List<Quiz_category>();

        // categoryList = (from cat in _context.quiz_Categories select cat).ToList();

        // categoryList.Insert(0, new Quiz_category { qc_Id = 0, qc_type = "Select" });

        //            ViewBag.ListOfCategory = categoryList;


        //if (ViewBag.ListOfCategory == null)
        //{
        //    ViewBag.ErrorMessage = $"View Bage is Empty or null";
        //    return View("NotFound");
        //}

        //  if(_quiz_CategoryRepository.GetAllCategory()==null)
        // ViewBag.CategoryList
        //List<Quiz_category> l1 = new List<Quiz_category>();
        //l1 = (from c in _quiz_CategoryRepository.quiz_Categories select c).ToList();
        //l1.Insert(0, new Quiz_category { qc_Id = 0, qc_type = "--Select any quiz category--" });
        //ViewBag.message = l1;
        //  return View();
        // }


    }
}
