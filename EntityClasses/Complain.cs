using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DefaultValue("NULL")]
        public string UserComplain { get; set; }

        [DefaultValue("NULL")]
        public string ComplainGroup { get; set; }
    }
}
