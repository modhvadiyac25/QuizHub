using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public interface IQuiz_categoryRepository
    {
        Quiz_category GetType(int Id);
        Quiz_category Add(Quiz_category quiz_Category);
        Quiz_category Delete(int Id);
    }
}
