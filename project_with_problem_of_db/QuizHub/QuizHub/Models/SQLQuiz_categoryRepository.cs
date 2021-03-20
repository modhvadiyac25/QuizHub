using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class SQLQuiz_categoryRepository : IQuiz_categoryRepository
    {
        private readonly AppDbContext context;

        public SQLQuiz_categoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Quiz_category Add(Quiz_category quiz_Category)
        {
            context.quiz_Categories.Add(quiz_Category);
            context.SaveChanges();
            return quiz_Category;
            throw new NotImplementedException();
        }

        public Quiz_category Delete(int Id)
        {
            Quiz_category quiz_Category = context.quiz_Categories.Find(Id);
            if(quiz_Category != null)
            {
                context.quiz_Categories.Remove(quiz_Category);
                context.SaveChanges();
            }
            return quiz_Category;
            throw new NotImplementedException();
        }

        public Quiz_category GetType(int Id)
        {
            return context.quiz_Categories.Find(Id);
            throw new NotImplementedException();
        }

        public IEnumerable<Quiz_category> GetAllCategory()
        {
            return context.quiz_Categories;
        }
    }
}
