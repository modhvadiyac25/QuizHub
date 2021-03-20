using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public SQLUserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public User Add(User user)
        {
            context.users.Add(user);
            context.SaveChanges();
            return user;
            throw new NotImplementedException();
        }

        public User Delete(string email)
        {
            User user = context.users.Find(email);
            if (user != null)
            {
                context.users.Remove(user);
                context.SaveChanges();
            }
            return user;
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.users;
            throw new NotImplementedException();
        }

        public User GetUser(int Id)
        {
            return context.users.Find(Id);
            throw new NotImplementedException();
        }

        public User Update(User UserChanges)
        {
            var user = context.users.Attach(UserChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return UserChanges;
            throw new NotImplementedException();
        }
    }
}
