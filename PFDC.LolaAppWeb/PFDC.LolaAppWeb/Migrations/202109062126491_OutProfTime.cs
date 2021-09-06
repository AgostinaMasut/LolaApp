namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OutProfTime : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.ProfessionalTimelines", "UserId", "dbo.Users");
            DropIndex("dbo.ProfessionalTimelines", new[] { "UserId" });
            DropIndex("dbo.ProfessionalTimelines", new[] { "Branch_Id" });
            DropTable("dbo.ProfessionalTimelines");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProfessionalTimelines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.Int(nullable: false),
                        Input = c.DateTime(nullable: false),
                        Output = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        Item1BranchId = c.Int(nullable: false),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProfessionalTimelines", "Branch_Id");
            CreateIndex("dbo.ProfessionalTimelines", "UserId");
            AddForeignKey("dbo.ProfessionalTimelines", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches", "Id");
        }
    }
}
