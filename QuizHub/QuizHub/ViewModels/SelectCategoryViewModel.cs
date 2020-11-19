using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizHub.ViewModels
{
    public class SelectCategoryViewModel
    {
        [Key,Required]
        public string qc_Id { get; set;  }

        public string qc_Type { get; set; }

        public List<string> categories { get; set; }

        public SelectCategoryViewModel()
        {
            categories = new List<string>();
        }
    }
}
