using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
   public class UserInfoClass
    {
        public static void AddUser(string Uname, string UGender,int UAge)
        {
            var context = new ContextDb();

            context.UserInfos.Add(new UserInfo()
            {
                UserName = Uname,
                Gender = UGender,
                Age = UAge

            });
            context.SaveChanges();
        }
    }
}
