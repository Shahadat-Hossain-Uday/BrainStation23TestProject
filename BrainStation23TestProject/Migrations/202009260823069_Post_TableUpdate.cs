namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Post_TableUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "totalCmntCount", c => c.Long(nullable: false));
            DropColumn("dbo.Post", "totalpostCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "totalpostCount", c => c.Long(nullable: false));
            DropColumn("dbo.Post", "totalCmntCount");
        }
    }
}
