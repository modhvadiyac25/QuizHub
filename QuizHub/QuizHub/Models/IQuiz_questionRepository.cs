using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public interface IQuiz_questionRepository
    {
        Quiz_question GetQuestion(int qq_id);

        Quiz_question AddQuestion(Quiz_question quiz_Question_Add);
        //i had change here also
        //Quiz_question DeleteQuestion(Quiz_question quiz_Question_Del);
        Quiz_question DeleteQuestion(int Id);

        Quiz_question UpdateQuestion(Quiz_question quiz_Question_Upd);
    }
}
