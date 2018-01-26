namespace EntityClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Complains", "ComplainGroup", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Complains", "ComplainGroup");
        }
    }
}
