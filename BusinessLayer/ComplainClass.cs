using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
    public class ComplainClass
    {
        public static void SubmitComplain(string userN, string a, string a1)
        {
            var context = new ContextDb();

            context.Complains.Add(new Complain()
            {
                UserName = userN,
                ComplainGroup = a,
                UserComplain = a1
            });
            context.SaveChanges();
        }

        public static void AddComplain(string a1)
        {
            var context = new ContextDb();

            context.ComplainLists.Add(new ComplainList()
            {
                ComplainCategory = a1
                
            });
            context.SaveChanges();
        }

    }
}
