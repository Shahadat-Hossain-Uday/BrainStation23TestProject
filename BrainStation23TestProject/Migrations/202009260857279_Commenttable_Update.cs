namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commenttable_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "UserID", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comment", "UserID");
        }
    }
}
