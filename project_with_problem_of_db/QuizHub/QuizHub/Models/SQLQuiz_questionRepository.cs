using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class SQLQuiz_questionRepository : IQuiz_questionRepository
    {

        private readonly AppDbContext context;

        public SQLQuiz_questionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Quiz_question AddQuestion(Quiz_question quiz_Question_Add)
        {
            context.quiz_Questions.Add(quiz_Question_Add);
            context.SaveChanges();
            return quiz_Question_Add;
            throw new NotImplementedException();
        }
        //i had chage here 
        //public Quiz_question DeleteQuestion(Quiz_question quiz_Question_Del)
        public Quiz_question DeleteQuestion(int Id)
        {
            Quiz_question quiz_Question = context.quiz_Questions.Find(Id);
            if (quiz_Question != null)
            {
                context.quiz_Questions.Remove(quiz_Question);
                context.SaveChanges();
            }
            return quiz_Question;
            throw new NotImplementedException();
        }

        public Quiz_question GetQuestion(int qq_id)
        {
            return context.quiz_Questions.Find(qq_id);
            throw new NotImplementedException();
        }

        public Quiz_question UpdateQuestion(Quiz_question quiz_Question_Upd)
        {
            var quiz_Question = context.quiz_Questions.Attach(quiz_Question_Upd);
            quiz_Question.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return quiz_Question_Upd;
            throw new NotImplementedException();
        }
    }
}
