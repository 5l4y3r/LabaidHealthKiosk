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
        public static void AddQuestion(string userN, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10, string a11, string a12, string a13, string a14)
        {
            var context = new ContextDb();

            context.Feedbacks.Add(new Feedback()
            {
                UserName = userN,
                Ans1 = a1,
                Ans2 = a2,
                Ans3 = a3,
                Ans4 = a4,
                Ans5 = a5,
                Ans6 = a6,
                Ans7 = a7,
                Ans8 = a8,
                Ans9 = a9,
                Ans10 = a10,
                Ans11 = a11,
                Ans12 = a12,
                Ans13 = a13,
                Ans14 = a14

            });
            context.SaveChanges();
        }
    }
}
