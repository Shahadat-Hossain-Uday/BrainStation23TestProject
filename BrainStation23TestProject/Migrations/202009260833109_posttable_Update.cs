namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class posttable_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "PostName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Post", "PostName");
        }
    }
}
