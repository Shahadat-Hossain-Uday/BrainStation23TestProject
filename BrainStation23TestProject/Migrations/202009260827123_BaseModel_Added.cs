namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseModel_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminUser", "CreateBy", c => c.String());
            AddColumn("dbo.AdminUser", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AdminUser", "UpdateBy", c => c.String());
            AddColumn("dbo.AdminUser", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comment", "CreateBy", c => c.String());
            AddColumn("dbo.Comment", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comment", "UpdateBy", c => c.String());
            AddColumn("dbo.Comment", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Post", "CreateBy", c => c.String());
            AddColumn("dbo.Post", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Post", "UpdateBy", c => c.String());
            AddColumn("dbo.Post", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "CreateBy", c => c.String());
            AddColumn("dbo.User", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "UpdateBy", c => c.String());
            AddColumn("dbo.User", "UpdateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "UpdateDate");
            DropColumn("dbo.User", "UpdateBy");
            DropColumn("dbo.User", "CreateDate");
            DropColumn("dbo.User", "CreateBy");
            DropColumn("dbo.Post", "UpdateDate");
            DropColumn("dbo.Post", "UpdateBy");
            DropColumn("dbo.Post", "CreateDate");
            DropColumn("dbo.Post", "CreateBy");
            DropColumn("dbo.Comment", "UpdateDate");
            DropColumn("dbo.Comment", "UpdateBy");
            DropColumn("dbo.Comment", "CreateDate");
            DropColumn("dbo.Comment", "CreateBy");
            DropColumn("dbo.AdminUser", "UpdateDate");
            DropColumn("dbo.AdminUser", "UpdateBy");
            DropColumn("dbo.AdminUser", "CreateDate");
            DropColumn("dbo.AdminUser", "CreateBy");
        }
    }
}
