namespace BrainStation23TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin_Post_Comment_TableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUser",
                c => new
                    {
                        AdminID = c.Long(nullable: false, identity: true),
                        AdminName = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentID = c.Long(nullable: false, identity: true),
                        postID = c.Long(nullable: false),
                        Comments = c.String(),
                        Like = c.Long(nullable: false),
                        Dislike = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Post", t => t.postID, cascadeDelete: true)
                .Index(t => t.postID);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        postID = c.Long(nullable: false, identity: true),
                        AdminID = c.Long(nullable: false),
                        PostedDate = c.DateTime(nullable: false),
                        totalpostCount = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.postID)
                .ForeignKey("dbo.AdminUser", t => t.AdminID, cascadeDelete: true)
                .Index(t => t.AdminID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "postID", "dbo.Post");
            DropForeignKey("dbo.Post", "AdminID", "dbo.AdminUser");
            DropIndex("dbo.Post", new[] { "AdminID" });
            DropIndex("dbo.Comment", new[] { "postID" });
            DropTable("dbo.User");
            DropTable("dbo.Post");
            DropTable("dbo.Comment");
            DropTable("dbo.AdminUser");
        }
    }
}
