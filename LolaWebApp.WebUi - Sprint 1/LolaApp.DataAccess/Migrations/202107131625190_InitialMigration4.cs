namespace LolaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Protocol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        IdTypeTreatment = c.Int(nullable: false),
                        NumberSession = c.Int(nullable: false),
                        DurationSession = c.Int(nullable: false),
                        IdFrequency = c.Int(nullable: false),
                        IdMachineType = c.Int(nullable: false),
                        IdStretcher = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.User", "CuitCuil", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "CuitCuil", c => c.Int(nullable: false));
            DropTable("dbo.Protocol");
        }
    }
}
