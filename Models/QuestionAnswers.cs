using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoC_StackOverflow.Models
{
    public class QuestionAnswers
    {
        public Questions quest { get; set; }
        public List<Answers> answer { get; set; }
    }
}
