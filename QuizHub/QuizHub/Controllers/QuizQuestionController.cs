using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Controllers
{
    public class QuizQuestionController : Controller
    {
        private readonly IQuiz_questionRepository _QuestionRepository;

        public QuizQuestionController(IQuiz_questionRepository quiz_QuestionRepository)
        {
            _QuestionRepository = quiz_QuestionRepository;
        }
    }
}
