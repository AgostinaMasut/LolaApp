namespace LolaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProfessionalTimeline", "IdUser");
            RenameColumn(table: "dbo.ProfessionalTimeline", name: "User_Id", newName: "IdUser");
            RenameIndex(table: "dbo.ProfessionalTimeline", name: "IX_User_Id", newName: "IX_IdUser");
            AddColumn("dbo.Branch", "Name", c => c.String());
            AddColumn("dbo.Branch", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Branch", "Street", c => c.String());
            AddColumn("dbo.Branch", "StreetNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Branch", "Neighbourhood", c => c.String());
            AddColumn("dbo.Branch", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Branch", "City", c => c.String());
            AddColumn("dbo.ProfessionalTimeline", "Day", c => c.String());
            AddColumn("dbo.ProfessionalTimeline", "Input", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProfessionalTimeline", "Output", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Name", c => c.String());
            AddColumn("dbo.User", "LastName", c => c.String());
            AddColumn("dbo.User", "Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Street", c => c.String());
            AddColumn("dbo.User", "StreetNumber", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Neighbourhood", c => c.String());
            AddColumn("dbo.User", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.User", "City", c => c.String());
            AddColumn("dbo.User", "Mobile", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Enable", c => c.Byte(nullable: false));
            AddColumn("dbo.Sex", "Description", c => c.String());
            AddColumn("dbo.UserType", "Description", c => c.String());
            DropColumn("dbo.Branch", "Nombre");
            DropColumn("dbo.Branch", "Telefono");
            DropColumn("dbo.Branch", "Calle");
            DropColumn("dbo.Branch", "NumeroCalle");
            DropColumn("dbo.Branch", "Barrio");
            DropColumn("dbo.Branch", "CP");
            DropColumn("dbo.Branch", "Localidad");
            DropColumn("dbo.ProfessionalTimeline", "Dia");
            DropColumn("dbo.ProfessionalTimeline", "Ingreso");
            DropColumn("dbo.ProfessionalTimeline", "Salida");
            DropColumn("dbo.User", "Nombre");
            DropColumn("dbo.User", "Apellido");
            DropColumn("dbo.User", "FechaNacimiento");
            DropColumn("dbo.User", "Calle");
            DropColumn("dbo.User", "NumeroCalle");
            DropColumn("dbo.User", "Barrio");
            DropColumn("dbo.User", "CP");
            DropColumn("dbo.User", "Localidad");
            DropColumn("dbo.User", "Celular");
            DropColumn("dbo.User", "Habilitado");
            DropColumn("dbo.Sex", "Descripcion");
            DropColumn("dbo.UserType", "Descripcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserType", "Descripcion", c => c.String());
            AddColumn("dbo.Sex", "Descripcion", c => c.String());
            AddColumn("dbo.User", "Habilitado", c => c.Byte(nullable: false));
            AddColumn("dbo.User", "Celular", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Localidad", c => c.String());
            AddColumn("dbo.User", "CP", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Barrio", c => c.String());
            AddColumn("dbo.User", "NumeroCalle", c => c.Int(nullable: false));
            AddColumn("dbo.User", "Calle", c => c.String());
            AddColumn("dbo.User", "FechaNacimiento", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Apellido", c => c.String());
            AddColumn("dbo.User", "Nombre", c => c.String());
            AddColumn("dbo.ProfessionalTimeline", "Salida", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProfessionalTimeline", "Ingreso", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProfessionalTimeline", "Dia", c => c.String());
            AddColumn("dbo.Branch", "Localidad", c => c.String());
            AddColumn("dbo.Branch", "CP", c => c.Int(nullable: false));
            AddColumn("dbo.Branch", "Barrio", c => c.String());
            AddColumn("dbo.Branch", "NumeroCalle", c => c.Int(nullable: false));
            AddColumn("dbo.Branch", "Calle", c => c.String());
            AddColumn("dbo.Branch", "Telefono", c => c.Int(nullable: false));
            AddColumn("dbo.Branch", "Nombre", c => c.String());
            DropColumn("dbo.UserType", "Description");
            DropColumn("dbo.Sex", "Description");
            DropColumn("dbo.User", "Enable");
            DropColumn("dbo.User", "Mobile");
            DropColumn("dbo.User", "City");
            DropColumn("dbo.User", "ZipCode");
            DropColumn("dbo.User", "Neighbourhood");
            DropColumn("dbo.User", "StreetNumber");
            DropColumn("dbo.User", "Street");
            DropColumn("dbo.User", "Birthday");
            DropColumn("dbo.User", "LastName");
            DropColumn("dbo.User", "Name");
            DropColumn("dbo.ProfessionalTimeline", "Output");
            DropColumn("dbo.ProfessionalTimeline", "Input");
            DropColumn("dbo.ProfessionalTimeline", "Day");
            DropColumn("dbo.Branch", "City");
            DropColumn("dbo.Branch", "ZipCode");
            DropColumn("dbo.Branch", "Neighbourhood");
            DropColumn("dbo.Branch", "StreetNumber");
            DropColumn("dbo.Branch", "Street");
            DropColumn("dbo.Branch", "PhoneNumber");
            DropColumn("dbo.Branch", "Name");
            RenameIndex(table: "dbo.ProfessionalTimeline", name: "IX_IdUser", newName: "IX_User_Id");
            RenameColumn(table: "dbo.ProfessionalTimeline", name: "IdUser", newName: "User_Id");
            AddColumn("dbo.ProfessionalTimeline", "IdUser", c => c.Int());
        }
    }
}
