using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
    public class QuestionClass
    {
        public static void AddQuestion(string qgroup, string qname)
        {
            var context = new ContextDb();

            context.Questions.Add(new Question()
            {
                QuestionGroup = qgroup,
                Ques = qname
            });
            context.SaveChanges();
        }

     
    }
}
