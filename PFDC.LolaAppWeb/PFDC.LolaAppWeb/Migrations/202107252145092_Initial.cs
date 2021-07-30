namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        DNI = c.String(),
                        CuitCuil = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Street = c.String(),
                        StreetNumber = c.Int(nullable: false),
                        Neighbourhood = c.String(),
                        ZipCode = c.Int(nullable: false),
                        City = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Enable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
