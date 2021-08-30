namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProfessionalTimelines", "Input", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProfessionalTimelines", "Output", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProfessionalTimelines", "Output", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.ProfessionalTimelines", "Input", c => c.Time(nullable: false, precision: 7));
        }
    }
}
