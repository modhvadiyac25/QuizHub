using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public interface IUser_progressRepository
    {
        IEnumerable<User_progress> GetUser_Progresses(int ID);
        User_progress AddProgress(User_progress user_Progress);
    }
}
