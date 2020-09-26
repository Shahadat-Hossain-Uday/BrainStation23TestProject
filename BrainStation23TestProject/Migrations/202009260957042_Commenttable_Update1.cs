namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commenttable_Update1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Comment", "UserID");
            AddForeignKey("dbo.Comment", "UserID", "dbo.User", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "UserID", "dbo.User");
            DropIndex("dbo.Comment", new[] { "UserID" });
        }
    }
}
