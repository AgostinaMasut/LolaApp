namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertypeandsex : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "PasswordConfirm", c => c.String());
            AddColumn("dbo.Users", "UserTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "SexId", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "DNI", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Users", "CuitCuil", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Users", "Street", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Mobile", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "UserTypeId");
            CreateIndex("dbo.Users", "SexId");
            AddForeignKey("dbo.Users", "SexId", "dbo.Sexes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.Users", "SexId", "dbo.Sexes");
            DropIndex("dbo.Users", new[] { "SexId" });
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Mobile", c => c.String());
            AlterColumn("dbo.Users", "City", c => c.String());
            AlterColumn("dbo.Users", "Street", c => c.String());
            AlterColumn("dbo.Users", "CuitCuil", c => c.String());
            AlterColumn("dbo.Users", "DNI", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            DropColumn("dbo.Users", "SexId");
            DropColumn("dbo.Users", "UserTypeId");
            DropColumn("dbo.Users", "PasswordConfirm");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Sexes");
        }
    }
}
