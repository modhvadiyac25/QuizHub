using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<User_progress> user_Progresses { get; set; }
        public DbSet<Quiz_category> quiz_Categories { get; set; }
        public DbSet<Quiz_question> quiz_Questions { get; set; }
    }
}
