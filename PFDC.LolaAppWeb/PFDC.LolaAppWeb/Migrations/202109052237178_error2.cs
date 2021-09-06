namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class error2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProfessionalTimelines", "BranchId", "dbo.Branches");
            DropIndex("dbo.ProfessionalTimelines", new[] { "BranchId" });
            RenameColumn(table: "dbo.ProfessionalTimelines", name: "BranchId", newName: "Branch_Id");
            AddColumn("dbo.ProfessionalTimelines", "Item1BranchId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProfessionalTimelines", "Branch_Id", c => c.Int());
            CreateIndex("dbo.ProfessionalTimelines", "Branch_Id");
            AddForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.ProfessionalTimelines", new[] { "Branch_Id" });
            AlterColumn("dbo.ProfessionalTimelines", "Branch_Id", c => c.Int(nullable: false));
            DropColumn("dbo.ProfessionalTimelines", "Item1BranchId");
            RenameColumn(table: "dbo.ProfessionalTimelines", name: "Branch_Id", newName: "BranchId");
            CreateIndex("dbo.ProfessionalTimelines", "BranchId");
            AddForeignKey("dbo.ProfessionalTimelines", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
        }
    }
}
