using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
   public class Question
    {
        public Question() { }

        public int? Id { get; set; }
        public string QuestionGroup { get; set; }
        public string Ques { get; set; }
    }
}
