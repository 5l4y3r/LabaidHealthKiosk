using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
   public class AnswerClass
    {
        public static void AddQuestion(string userN, string a1)
        {
            var context = new ContextDb();

            context.Feedbacks.Add(new Feedback()
            {
                UserName = userN,
                Ans = a1         
            });
            context.SaveChanges();
        }
    }
}
