using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class SQLUser_progressRepository : IUser_progressRepository
    {
        private readonly AppDbContext context;

        public SQLUser_progressRepository(AppDbContext context)
        {
            this.context = context;
        }

        public User_progress AddProgress(User_progress user_Progress)
        {
            context.user_Progresses.Add(user_Progress);
            context.SaveChanges();
            return user_Progress;
            throw new NotImplementedException();
        }

        public IEnumerable<User_progress> GetUser_Progresses(int ID)
        {
          //  return context.user_Progresses.Find(ID);
            //problem ocuured here
            throw new NotImplementedException();
        }
    }
}
