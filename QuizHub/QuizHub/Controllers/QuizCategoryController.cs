using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizHub.ViewModels;

namespace QuizHub.Controllers
{
    [Authorize(Roles = "Admin")]
    public class QuizCategoryController : Controller
    {
        private readonly IQuiz_categoryRepository _quiz_CategoryRepository;


        public QuizCategoryController(IQuiz_categoryRepository quiz_CategoryRepository)
        {
            this._quiz_CategoryRepository = quiz_CategoryRepository;
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
       
        

    }
}
