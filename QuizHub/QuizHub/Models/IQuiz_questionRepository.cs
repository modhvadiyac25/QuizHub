using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    interface IQuiz_questionRepository
    {
        Quiz_question GetQuestion(int qq_id);

        Quiz_question AddQuestion(Quiz_question quiz_Question_Add);

        Quiz_question DeleteQuestion(Quiz_question quiz_Question_Del);

        Quiz_question UpdateQuestion(Quiz_question quiz_Question_Upd);
    }
}
