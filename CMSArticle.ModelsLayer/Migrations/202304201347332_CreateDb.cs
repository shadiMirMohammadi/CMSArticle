namespace CMSArticle.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Family = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        ImageName = c.String(maxLength: 70, unicode: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Role_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Role", t => t.Role_RoleId)
                .Index(t => t.Role_RoleId);
            
            CreateTable(
                "dbo.T_Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.T_Article",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 80),
                        Content = c.String(nullable: false, maxLength: 4000),
                        ImageName = c.String(nullable: false, maxLength: 70, unicode: false),
                        LikeCount = c.Int(nullable: false),
                        VisitCount = c.Int(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Category_CategoryId = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.T_Category", t => t.Category_CategoryId)
                .ForeignKey("dbo.T_User", t => t.User_Id)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.T_Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 80),
                        ImageName = c.String(maxLength: 70, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.T_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Family = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        ImageName = c.String(maxLength: 70, unicode: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Role_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Role", t => t.Role_RoleId)
                .Index(t => t.Role_RoleId);
            
            CreateTable(
                "dbo.T_Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 200),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Admin_Id = c.Int(),
                        Article_ArticleId = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.T_Admin", t => t.Admin_Id)
                .ForeignKey("dbo.T_Article", t => t.Article_ArticleId)
                .ForeignKey("dbo.T_User", t => t.User_Id)
                .Index(t => t.Admin_Id)
                .Index(t => t.Article_ArticleId)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_Comment", "User_Id", "dbo.T_User");
            DropForeignKey("dbo.T_Comment", "Article_ArticleId", "dbo.T_Article");
            DropForeignKey("dbo.T_Comment", "Admin_Id", "dbo.T_Admin");
            DropForeignKey("dbo.T_Article", "User_Id", "dbo.T_User");
            DropForeignKey("dbo.T_User", "Role_RoleId", "dbo.T_Role");
            DropForeignKey("dbo.T_Article", "Category_CategoryId", "dbo.T_Category");
            DropForeignKey("dbo.T_Admin", "Role_RoleId", "dbo.T_Role");
            DropIndex("dbo.T_Comment", new[] { "User_Id" });
            DropIndex("dbo.T_Comment", new[] { "Article_ArticleId" });
            DropIndex("dbo.T_Comment", new[] { "Admin_Id" });
            DropIndex("dbo.T_User", new[] { "Role_RoleId" });
            DropIndex("dbo.T_Article", new[] { "User_Id" });
            DropIndex("dbo.T_Article", new[] { "Category_CategoryId" });
            DropIndex("dbo.T_Admin", new[] { "Role_RoleId" });
            DropTable("dbo.T_Comment");
            DropTable("dbo.T_User");
            DropTable("dbo.T_Category");
            DropTable("dbo.T_Article");
            DropTable("dbo.T_Role");
            DropTable("dbo.T_Admin");
        }
    }
}
