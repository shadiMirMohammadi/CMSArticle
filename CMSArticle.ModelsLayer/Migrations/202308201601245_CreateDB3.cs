namespace CMSArticle.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.T_Comment", "Admin_Id", "dbo.T_Admin");
            DropForeignKey("dbo.T_Comment", "Article_ArticleId", "dbo.T_Article");
            DropForeignKey("dbo.T_Comment", "User_Id", "dbo.T_User");
            DropIndex("dbo.T_Comment", new[] { "Admin_Id" });
            DropIndex("dbo.T_Comment", new[] { "Article_ArticleId" });
            DropIndex("dbo.T_Comment", new[] { "User_Id" });
            RenameColumn(table: "dbo.T_Comment", name: "Admin_Id", newName: "AdminId");
            RenameColumn(table: "dbo.T_Comment", name: "Article_ArticleId", newName: "ArticleId");
            RenameColumn(table: "dbo.T_Comment", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.T_Comment", "AdminId", c => c.Int(nullable: false));
            AlterColumn("dbo.T_Comment", "ArticleId", c => c.Int(nullable: false));
            AlterColumn("dbo.T_Comment", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.T_Comment", "AdminId");
            CreateIndex("dbo.T_Comment", "UserId");
            CreateIndex("dbo.T_Comment", "ArticleId");
            AddForeignKey("dbo.T_Comment", "AdminId", "dbo.T_Admin", "Id", cascadeDelete: true);
            AddForeignKey("dbo.T_Comment", "ArticleId", "dbo.T_Article", "ArticleId", cascadeDelete: true);
            AddForeignKey("dbo.T_Comment", "UserId", "dbo.T_User", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_Comment", "UserId", "dbo.T_User");
            DropForeignKey("dbo.T_Comment", "ArticleId", "dbo.T_Article");
            DropForeignKey("dbo.T_Comment", "AdminId", "dbo.T_Admin");
            DropIndex("dbo.T_Comment", new[] { "ArticleId" });
            DropIndex("dbo.T_Comment", new[] { "UserId" });
            DropIndex("dbo.T_Comment", new[] { "AdminId" });
            AlterColumn("dbo.T_Comment", "UserId", c => c.Int());
            AlterColumn("dbo.T_Comment", "ArticleId", c => c.Int());
            AlterColumn("dbo.T_Comment", "AdminId", c => c.Int());
            RenameColumn(table: "dbo.T_Comment", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.T_Comment", name: "ArticleId", newName: "Article_ArticleId");
            RenameColumn(table: "dbo.T_Comment", name: "AdminId", newName: "Admin_Id");
            CreateIndex("dbo.T_Comment", "User_Id");
            CreateIndex("dbo.T_Comment", "Article_ArticleId");
            CreateIndex("dbo.T_Comment", "Admin_Id");
            AddForeignKey("dbo.T_Comment", "User_Id", "dbo.T_User", "Id");
            AddForeignKey("dbo.T_Comment", "Article_ArticleId", "dbo.T_Article", "ArticleId");
            AddForeignKey("dbo.T_Comment", "Admin_Id", "dbo.T_Admin", "Id");
        }
    }
}
