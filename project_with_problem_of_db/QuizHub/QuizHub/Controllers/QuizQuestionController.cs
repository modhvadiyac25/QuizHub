using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using QuizHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Controllers
{
    public class QuizQuestionController : Controller
    {
        private readonly IQuiz_questionRepository _QuestionRepository;
        private readonly IQuiz_categoryRepository _quiz_CategoryRepository;
        private readonly AppDbContext _context;

        public QuizQuestionController(AppDbContext context,IQuiz_questionRepository quiz_QuestionRepository, IQuiz_categoryRepository quiz_CategoryRepository)
        {
            _QuestionRepository = quiz_QuestionRepository;
            _quiz_CategoryRepository = quiz_CategoryRepository;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                string categoryName = model.qq_cat;
                var qcid = from x in _context.quiz_Categories where x.qc_type == categoryName select x.qc_Id; 
                var quizeQuestion = new Quiz_question
                {
                  //  quiz_catqc_id = qcid,
                    qq_question = model.qq_question,
                    qq_opta = model.qq_opta, 
                    qq_optb = model.qq_optb,
                    qq_optc = model.qq_optc,
                    qq_optd =model.qq_optd,
                    qq_ans = model.qq_ans
    };
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateQuestion()
        {
            var model = new CreateQuestionViewModel { };

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
    }
}
