using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Feedback
    {
        public Feedback() { }

        public int? Id { get; set; }
        public string UserName { get; set; }
        [DefaultValue("NULL")]
        public string Ans1 { get; set; }
        [DefaultValue("NULL")]
        public string Ans2 { get; set; }
        [DefaultValue("NULL")]
        public string Ans3 { get; set; }
        [DefaultValue("NULL")]
        public string Ans4 { get; set; }
        [DefaultValue("NULL")]
        public string Ans5 { get; set; }
        [DefaultValue("NULL")]
        public string Ans6 { get; set; }
        [DefaultValue("NULL")]
        public string Ans7 { get; set; }
        [DefaultValue("NULL")]
        public string Ans8 { get; set; }
        [DefaultValue("NULL")]
        public string Ans9 { get; set; }
        [DefaultValue("NULL")]
        public string Ans10 { get; set; }
        [DefaultValue("NULL")]
        public string Ans11 { get; set; }
        [DefaultValue("NULL")]
        public string Ans12 { get; set; }
        [DefaultValue("NULL")]
        public string Ans13 { get; set; }
        [DefaultValue("NULL")]
        public string Ans14 { get; set; }
    }
}
