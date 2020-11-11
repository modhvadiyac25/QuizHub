using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace QuizHub.Models
{
    public class Quiz_question
    {
        public int qq_id { get; set; }

        public string qq_opta { get; set; }

        public string qq_optb { get; set; }

        public string qq_optc { get; set; }

        public string qq_optd { get; set; }

        public string qq_ans { get; set; }

        public Quiz_category qc_id { get; set; }
        public Quiz_category quiz_Category { get; set; }

    }
}


/*quiz_questions


  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
 */


