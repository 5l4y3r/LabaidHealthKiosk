using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Advertisement
    {
        public Advertisement() { }

        public int? Id { get; set; }
        public string UserName { get; set; }
        public string ImageAdvertiseLink { get; set; }
        public string VIdeoAdvertiseLink { get; set; }
    }
}
