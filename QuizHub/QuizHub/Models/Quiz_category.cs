using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class Quiz_category
    {   [Key]
        public int qc_Id { get; set; }

        public string qc_type { get; set; }

        public ICollection<Quiz_question> quiz_que { get; set; }
    }
}
