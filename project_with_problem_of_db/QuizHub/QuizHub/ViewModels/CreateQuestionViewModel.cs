using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.ViewModels
{
    public class CreateQuestionViewModel
    {
        public CreateQuestionViewModel()
        {
            categories = new List<string>();
        }

        [Key]
        public int qq_id { get; set; }

        public string qq_cat { get; set; }

        [NotMapped]
        public List<string> categories { get; set; }
        
        public string qq_question { get; set; }

        public string qq_opta { get; set; }

        public string qq_optb { get; set; }

        public string qq_optc { get; set; }

        public string qq_optd { get; set; }

        public string qq_ans { get; set; }

        
    }
}
