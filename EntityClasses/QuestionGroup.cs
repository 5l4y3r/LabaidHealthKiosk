using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
   public class QuestionGroup
    {
        public QuestionGroup() { }

        public int? Id { get; set; }
        [DefaultValue("NULL")]
        public string GroupName { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
