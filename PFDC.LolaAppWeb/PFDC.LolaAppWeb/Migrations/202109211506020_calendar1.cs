namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calendar1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Calendars", newName: "CalendarEvents");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CalendarEvents", newName: "Calendars");
        }
    }
}
