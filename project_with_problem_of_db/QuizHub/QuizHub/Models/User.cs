using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class User
    {   
        [Key]
        public int u_id { get; set; }

        [Required]
        public string fname { get; set; }

        [Required]
        public string lname { get; set; }


        [Required,DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [MaxLength(10,ErrorMessage ="Mobile no must be 10 digits !!")]
        public string mno { get; set; }

        
        [MinLength(8,ErrorMessage ="Password must be greater then 8 characters !!")]
        [Required, DataType(DataType.Password)]
        public string password { get; set; }

        public ICollection<User_progress> user_Progresses { get; set; }
    }
}
