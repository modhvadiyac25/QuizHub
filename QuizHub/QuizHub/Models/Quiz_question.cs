using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.Models
{
    public class Quiz_question
    {
        public int qq_id { get; set; }

        public int qc_id { get; set; }

        public string qq_opta { get; set; }

        public string qq_optb { get; set; }

        public string qq_optc { get; set; }

        public string qq_optd { get; set; }

        public string qq_ans { get; set; }

        public int qc_id { get; set; }
        public Quiz_category quiz_Category { get; set; }

    }
}


/*quiz_questions

Qq_id primary key, auto increment
Qc_id foreigen key (Quiz_category, One To Many)
Q_question varchar(200)
Qq_opta varchar(100)
Qq_optb varchar(100)
Qq_optc varchar(100)
Qq_optd varchar(100)
Qq_ans varchar(100)

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
 */


