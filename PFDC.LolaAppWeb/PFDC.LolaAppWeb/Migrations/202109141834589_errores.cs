namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errores : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TurnoPruebas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TurnoPruebas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
