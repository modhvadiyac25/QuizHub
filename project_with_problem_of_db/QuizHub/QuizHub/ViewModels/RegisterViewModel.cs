using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace QuizHub.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string fname { get; set; }

        [Required]
        public string lname { get; set; }


        [Required, DataType(DataType.EmailAddress)]
       // [Remote(action:"IsEmailInUse" ,controller:"User")]
        public string email { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Mobile no must be 10 digits !!")]
        public string mno { get; set; }


        [MinLength(8, ErrorMessage = "Password must be greater then 8 characters !!")]
        [Required, DataType(DataType.Password)]
        public string password { get; set; }

        [MinLength(8, ErrorMessage = "Password must be greater then 8 characters !!")]
        [Display(Name ="Confirm Password")]
        [Required, DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Password and confirmation password do not match.")]
        public string confirm_password { get; set; }
    }
}
