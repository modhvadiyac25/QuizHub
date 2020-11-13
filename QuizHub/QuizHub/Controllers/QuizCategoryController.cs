using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Controllers
{
    public class QuizCategoryController : Controller
    {
        private readonly IQuiz_categoryRepository _CategoryRepository;

        public QuizCategoryController(IQuiz_categoryRepository quiz_CategoryRepository)
        {
            _CategoryRepository = quiz_CategoryRepository;
        }
    }
}
