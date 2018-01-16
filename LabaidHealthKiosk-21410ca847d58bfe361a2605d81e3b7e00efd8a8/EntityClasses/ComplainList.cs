using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
   public class ComplainList
    {
        public ComplainList() { }

        public int? Id { get; set; }
        public string ComplainCategory { get; set; }
        public string ComplainQues { get; set; }


    }
}
