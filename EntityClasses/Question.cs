using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Ques { get; set; }

        public int QuestionGroupRefId { get; set; }

        [ForeignKey("QuestionGroupRefId")]
        public QuestionGroup QuestionGroup { get; set; }


    }
}
