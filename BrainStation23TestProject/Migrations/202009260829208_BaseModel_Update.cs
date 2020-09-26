namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseModel_Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminUser", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.AdminUser", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Comment", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Comment", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Post", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Post", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.User", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.User", "UpdateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Post", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Post", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Comment", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Comment", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdminUser", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdminUser", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
