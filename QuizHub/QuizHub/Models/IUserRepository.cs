﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    interface IUserRepository
    {
        User GetUser(int Id);
        IEnumerable<User> GetAllUsers();
        User Add(User user);
        User Update(User UserChanges);
        User Delete(int Id);

    }
}
