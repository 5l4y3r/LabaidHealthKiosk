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
        public string Ans { get; set; }
     
       
    }
}
