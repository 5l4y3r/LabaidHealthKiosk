using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
   public class Question
    {
        public Question() { }

        public int? Id { get; set; }
        [DefaultValue("NULL")]
        public string QuestionGroup { get; set; }
        [DefaultValue("NULL")]
        public string Ques { get; set; }
    }
}
