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
        public string ComplainQA1 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA2 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA3 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA4 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA5 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA6 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA7 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA8 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA9 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA10 { get; set; }
        [DefaultValue("NULL")]
        public string ComplainQA11 { get; set; }

    }
}
