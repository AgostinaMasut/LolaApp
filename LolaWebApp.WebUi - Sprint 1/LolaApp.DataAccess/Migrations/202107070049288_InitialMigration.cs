namespace LolaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Telefono = c.Int(nullable: false),
                        Calle = c.String(),
                        NumeroCalle = c.Int(nullable: false),
                        Barrio = c.String(),
                        CP = c.Int(nullable: false),
                        Localidad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfessionalTimeline",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dia = c.String(),
                        Ingreso = c.DateTime(nullable: false),
                        Salida = c.DateTime(nullable: false),
                        IdUser = c.Int(),
                        IdBranch = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.IdBranch)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.IdBranch)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Sex",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.User", "Nombre", c => c.String());
            AddColumn("dbo.User", "Apellido", c => c.String());
            AddColumn("dbo.User", "DNI", c => c.Int(nullable: false));
            AddColumn("dbo.User", "CuitCuil", c => c.Int(nullable: false));
            AddColumn("dbo.User", "FechaNacimiento", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Calle", c => c.String());
            AddColumn("dbo.User", "NumeroCalle", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Barrio", c => c.String());
            AddColumn("dbo.User", "CP", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Localidad", c => c.String());
            AddColumn("dbo.User", "Celular", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Habilitado", c => c.Byte(nullable: false));
            AddColumn("dbo.User", "IdUserType", c => c.Int(nullable: false));
            AddColumn("dbo.User", "IdSex", c => c.Int(nullable: false));
            CreateIndex("dbo.User", "IdUserType");
            CreateIndex("dbo.User", "IdSex");
            AddForeignKey("dbo.User", "IdSex", "dbo.Sex", "Id", cascadeDelete: true);
            AddForeignKey("dbo.User", "IdUserType", "dbo.UserType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessionalTimeline", "User_Id", "dbo.User");
            DropForeignKey("dbo.User", "IdUserType", "dbo.UserType");
            DropForeignKey("dbo.User", "IdSex", "dbo.Sex");
            DropForeignKey("dbo.ProfessionalTimeline", "IdBranch", "dbo.Branch");
            DropIndex("dbo.User", new[] { "IdSex" });
            DropIndex("dbo.User", new[] { "IdUserType" });
            DropIndex("dbo.ProfessionalTimeline", new[] { "User_Id" });
            DropIndex("dbo.ProfessionalTimeline", new[] { "IdBranch" });
            DropColumn("dbo.User", "IdSex");
            DropColumn("dbo.User", "IdUserType");
            DropColumn("dbo.User", "Habilitado");
            DropColumn("dbo.User", "Celular");
            DropColumn("dbo.User", "Localidad");
            DropColumn("dbo.User", "CP");
            DropColumn("dbo.User", "Barrio");
            DropColumn("dbo.User", "NumeroCalle");
            DropColumn("dbo.User", "Calle");
            DropColumn("dbo.User", "FechaNacimiento");
            DropColumn("dbo.User", "CuitCuil");
            DropColumn("dbo.User", "DNI");
            DropColumn("dbo.User", "Apellido");
            DropColumn("dbo.User", "Nombre");
            DropTable("dbo.UserType");
            DropTable("dbo.Sex");
            DropTable("dbo.ProfessionalTimeline");
            DropTable("dbo.Branch");
        }
    }
}
