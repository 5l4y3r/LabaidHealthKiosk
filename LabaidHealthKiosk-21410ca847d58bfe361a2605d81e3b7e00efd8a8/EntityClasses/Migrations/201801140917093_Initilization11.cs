namespace EntityClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initilization11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advertisements", "AdType", c => c.String());
            AddColumn("dbo.Advertisements", "AdLink", c => c.String());
            DropColumn("dbo.Advertisements", "ImageAdvertiseLink");
            DropColumn("dbo.Advertisements", "VIdeoAdvertiseLink");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Advertisements", "VIdeoAdvertiseLink", c => c.String());
            AddColumn("dbo.Advertisements", "ImageAdvertiseLink", c => c.String());
            DropColumn("dbo.Advertisements", "AdLink");
            DropColumn("dbo.Advertisements", "AdType");
        }
    }
}
