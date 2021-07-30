namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchandPrfesionaTimeline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Street = c.String(),
                        StreetNumber = c.Int(nullable: false),
                        Neighbourhood = c.String(),
                        ZipCode = c.Int(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfessionalTimelines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(nullable: false),
                        Input = c.DateTime(nullable: false),
                        Output = c.DateTime(nullable: false),
                        IdUser = c.Int(nullable: false),
                        IdBranch = c.Int(nullable: false),
                        Branch_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Branch_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessionalTimelines", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ProfessionalTimelines", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.ProfessionalTimelines", new[] { "User_Id" });
            DropIndex("dbo.ProfessionalTimelines", new[] { "Branch_Id" });
            DropTable("dbo.ProfessionalTimelines");
            DropTable("dbo.Branches");
        }
    }
}
