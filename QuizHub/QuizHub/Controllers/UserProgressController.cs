using Microsoft.AspNetCore.Mvc;
using QuizHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Controllers
{
    public class UserProgressController : Controller
    {
        private readonly IUser_progressRepository _ProgressRepository;

        public UserProgressController(IUser_progressRepository user_ProgressRepository)
        {
            _ProgressRepository = user_ProgressRepository;
        }
    }
}
