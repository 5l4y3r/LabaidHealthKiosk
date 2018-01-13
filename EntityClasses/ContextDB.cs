using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    class ContextDb : DbContext
    {
        public ContextDb(): base("name=LabaidHealthKioskDB")
        {
        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        

    }
}
