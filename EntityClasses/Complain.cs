using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Complain
    {
        public Complain() { }

        public int? Id { get; set; }
        public string UserName { get; set; }
        public string ComplainCategory { get; set; }
        public string ComplainAbout { get; set; }
        public string ComplainAns { get; set; }

    }
}
