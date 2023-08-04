namespace CMSArticle.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.T_Article", "Category_CategoryId", "dbo.T_Category");
            DropForeignKey("dbo.T_Article", "User_Id", "dbo.T_User");
            DropIndex("dbo.T_Article", new[] { "Category_CategoryId" });
            DropIndex("dbo.T_Article", new[] { "User_Id" });
            RenameColumn(table: "dbo.T_Article", name: "Category_CategoryId", newName: "CategoryId");
            RenameColumn(table: "dbo.T_Article", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.T_Article", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.T_Article", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.T_Article", "UserId");
            CreateIndex("dbo.T_Article", "CategoryId");
            AddForeignKey("dbo.T_Article", "CategoryId", "dbo.T_Category", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.T_Article", "UserId", "dbo.T_User", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_Article", "UserId", "dbo.T_User");
            DropForeignKey("dbo.T_Article", "CategoryId", "dbo.T_Category");
            DropIndex("dbo.T_Article", new[] { "CategoryId" });
            DropIndex("dbo.T_Article", new[] { "UserId" });
            AlterColumn("dbo.T_Article", "UserId", c => c.Int());
            AlterColumn("dbo.T_Article", "CategoryId", c => c.Int());
            RenameColumn(table: "dbo.T_Article", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.T_Article", name: "CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.T_Article", "User_Id");
            CreateIndex("dbo.T_Article", "Category_CategoryId");
            AddForeignKey("dbo.T_Article", "User_Id", "dbo.T_User", "Id");
            AddForeignKey("dbo.T_Article", "Category_CategoryId", "dbo.T_Category", "CategoryId");
        }
    }
}
