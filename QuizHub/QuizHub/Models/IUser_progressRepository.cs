using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    interface IUser_progressRepository
    {
        IEnumerable<User_progress> GetUser_Progresses();
        User_progress AddProgress(User_progress user_Progress);
    }
}
