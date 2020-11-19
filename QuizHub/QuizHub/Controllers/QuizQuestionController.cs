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

        public QuizQuestionController(AppDbContext context, IQuiz_questionRepository quiz_QuestionRepository, IQuiz_categoryRepository quiz_CategoryRepository)
        {
            _QuestionRepository = quiz_QuestionRepository;
            _quiz_CategoryRepository = quiz_CategoryRepository;
            _context = context;
        }

        

        //[HttpGet]
        public async Task<IActionResult> ShowQuestion(SelectCategoryViewModel model)
        {

            /*
            if (type == null)
            {
                ViewBag.ErrorMessage = "type is empty";
                return View("NotFound");
            }
            else
            {
                ViewBag.msg = type;
            }
             */

            string type = null;
            type = model.qc_Type;

            List < Quiz_question > qq_list = new List<Quiz_question>();
            int id1 = 0;
            Quiz_question[] qqobj = new Quiz_question[5];
            try
            {
                var id = from x in _context.quiz_Categories where x.qc_type == type select x.qc_Id;
                id1 = id.FirstOrDefault();
            }
            catch (Exception e) { }

            var quiz_questions = from x in _context.quiz_Questions where x.qc_Id == id1 select x;

            ViewBag.linqinstance = quiz_questions;



          

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionViewModel model)
        {
            if (ModelState.IsValid)
            {
                string categoryName = model.qq_cat;
                var qcid =  (from x in _context.quiz_Categories where x.qc_type == categoryName select x.qc_Id);
                var quizeQuestion = new Quiz_question
                {                    
                    qc_Id = qcid.First(),
                    qq_question = model.qq_question,
                    qq_opta = model.qq_opta,
                    qq_optb = model.qq_optb,
                    qq_optc = model.qq_optc,
                    qq_optd = model.qq_optd,
                    qq_ans = model.qq_ans
                };

                var result = _QuestionRepository.AddQuestion(quizeQuestion);
                if (result == null)
                {
                    ModelState.AddModelError("",result.ToString());
                }
            }
            return RedirectToAction("Index","Home");
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
