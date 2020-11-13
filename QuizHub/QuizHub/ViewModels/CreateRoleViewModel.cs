using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.ViewModels
{
    public class CreateRoleViewModel
    {
        [Key]
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
