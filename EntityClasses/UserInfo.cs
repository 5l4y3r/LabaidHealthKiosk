using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
   public class UserInfo
    {
        public UserInfo() { }

       public int? Id { get; set; }
       public string UserName { get; set; }
       public string Gender { get; set; }
       public int Age { get; set; }
    }
}
