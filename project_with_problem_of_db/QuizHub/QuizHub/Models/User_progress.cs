using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class User_progress
    {   
        [Key]
        public int up_id { get; set; }

        public int rans  {get; set;}

        public int wans { get; set; }

        public DateTime date { get { return DateTime.Now; } }

        public int u_id { get; set; }

        public User user { get; set; }
    }
}
