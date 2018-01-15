using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
    public class QuestionClass
    {
        public static void AddQuestionGroup( string qname)
        {
            var context = new ContextDb();

            context.QuestionGroups.Add(new QuestionGroup()
            {
                
                GroupName = qname
            });
            context.SaveChanges();
           
        }
        public static void AddQuestion(string qgroup, string qname)
        {
            var context = new ContextDb();

            context.Questions.Add(new Question()
            {
                Ques = qname,
                QuestionGroup = qgroup
            });
            context.SaveChanges();

        }


    }
}
