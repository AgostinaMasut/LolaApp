namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InProfTime : DbMigration
    {
        public override void Up()
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
                        BranchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BranchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessionalTimelines", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProfessionalTimelines", "BranchId", "dbo.Branches");
            DropIndex("dbo.ProfessionalTimelines", new[] { "BranchId" });
            DropIndex("dbo.ProfessionalTimelines", new[] { "UserId" });
            DropTable("dbo.ProfessionalTimelines");
        }
    }
}
