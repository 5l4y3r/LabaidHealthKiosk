namespace EntityClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initilization1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        ImageAdvertiseLink = c.String(),
                        VIdeoAdvertiseLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComplainLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComplainCategory = c.String(),
                        ComplainQues = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Complains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        ComplainQA1 = c.String(),
                        ComplainQA2 = c.String(),
                        ComplainQA3 = c.String(),
                        ComplainQA4 = c.String(),
                        ComplainQA5 = c.String(),
                        ComplainQA6 = c.String(),
                        ComplainQA7 = c.String(),
                        ComplainQA8 = c.String(),
                        ComplainQA9 = c.String(),
                        ComplainQA10 = c.String(),
                        ComplainQA11 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Ans1 = c.String(),
                        Ans2 = c.String(),
                        Ans3 = c.String(),
                        Ans4 = c.String(),
                        Ans5 = c.String(),
                        Ans6 = c.String(),
                        Ans7 = c.String(),
                        Ans8 = c.String(),
                        Ans9 = c.String(),
                        Ans10 = c.String(),
                        Ans11 = c.String(),
                        Ans12 = c.String(),
                        Ans13 = c.String(),
                        Ans14 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionGroup = c.String(),
                        Ques = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfoes");
            DropTable("dbo.Questions");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Complains");
            DropTable("dbo.ComplainLists");
            DropTable("dbo.Advertisements");
        }
    }
}
