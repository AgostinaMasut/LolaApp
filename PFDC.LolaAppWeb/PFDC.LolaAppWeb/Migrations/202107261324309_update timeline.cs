namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetimeline : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.ProfessionalTimelines", "User_Id", "dbo.Users");
            DropIndex("dbo.ProfessionalTimelines", new[] { "Branch_Id" });
            DropIndex("dbo.ProfessionalTimelines", new[] { "User_Id" });
            RenameColumn(table: "dbo.ProfessionalTimelines", name: "Branch_Id", newName: "BranchId");
            RenameColumn(table: "dbo.ProfessionalTimelines", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.ProfessionalTimelines", "BranchId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProfessionalTimelines", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProfessionalTimelines", "UserId");
            CreateIndex("dbo.ProfessionalTimelines", "BranchId");
            AddForeignKey("dbo.ProfessionalTimelines", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfessionalTimelines", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.ProfessionalTimelines", "IdUser");
            DropColumn("dbo.ProfessionalTimelines", "IdBranch");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProfessionalTimelines", "IdBranch", c => c.Int(nullable: false));
            AddColumn("dbo.ProfessionalTimelines", "IdUser", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProfessionalTimelines", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProfessionalTimelines", "BranchId", "dbo.Branches");
            DropIndex("dbo.ProfessionalTimelines", new[] { "BranchId" });
            DropIndex("dbo.ProfessionalTimelines", new[] { "UserId" });
            AlterColumn("dbo.ProfessionalTimelines", "UserId", c => c.Int());
            AlterColumn("dbo.ProfessionalTimelines", "BranchId", c => c.Int());
            RenameColumn(table: "dbo.ProfessionalTimelines", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.ProfessionalTimelines", name: "BranchId", newName: "Branch_Id");
            CreateIndex("dbo.ProfessionalTimelines", "User_Id");
            CreateIndex("dbo.ProfessionalTimelines", "Branch_Id");
            AddForeignKey("dbo.ProfessionalTimelines", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches", "Id");
        }
    }
}
