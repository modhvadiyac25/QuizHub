using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizHub.ViewModels;

namespace QuizHub.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<User_progress> user_Progresses { get; set; }
        public DbSet<Quiz_category> quiz_Categories { get; set; }
        public DbSet<Quiz_question> quiz_Questions { get; set; }
        public DbSet<QuizHub.ViewModels.LoginViewModel> LoginViewModel { get; set; }
        public DbSet<QuizHub.ViewModels.CreateRoleViewModel> CreateRoleViewModel { get; set; }
    }
}
