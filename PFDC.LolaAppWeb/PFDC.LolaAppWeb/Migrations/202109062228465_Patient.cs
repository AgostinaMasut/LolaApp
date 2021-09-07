namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Patient : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Patients", new[] { "Sex_Id" });
            DropColumn("dbo.Patients", "SexId");
            RenameColumn(table: "dbo.Patients", name: "Sex_Id", newName: "SexId");
            AlterColumn("dbo.Patients", "SexId", c => c.Int());
            CreateIndex("dbo.Patients", "SexId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Patients", new[] { "SexId" });
            AlterColumn("dbo.Patients", "SexId", c => c.String());
            RenameColumn(table: "dbo.Patients", name: "SexId", newName: "Sex_Id");
            AddColumn("dbo.Patients", "SexId", c => c.String());
            CreateIndex("dbo.Patients", "Sex_Id");
        }
    }
}
