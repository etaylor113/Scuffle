namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedregistrationstatusanddayplan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RegistrationStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "MondayPlan", c => c.String());
            AddColumn("dbo.AspNetUsers", "TuesdayPlan", c => c.String());
            AddColumn("dbo.AspNetUsers", "WednesdayPlan", c => c.String());
            AddColumn("dbo.AspNetUsers", "ThursdayPlan", c => c.String());
            AddColumn("dbo.AspNetUsers", "FridayPlan", c => c.String());
            AddColumn("dbo.AspNetUsers", "SaturdayPlan", c => c.String());
            AddColumn("dbo.AspNetUsers", "SundayPlan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SundayPlan");
            DropColumn("dbo.AspNetUsers", "SaturdayPlan");
            DropColumn("dbo.AspNetUsers", "FridayPlan");
            DropColumn("dbo.AspNetUsers", "ThursdayPlan");
            DropColumn("dbo.AspNetUsers", "WednesdayPlan");
            DropColumn("dbo.AspNetUsers", "TuesdayPlan");
            DropColumn("dbo.AspNetUsers", "MondayPlan");
            DropColumn("dbo.AspNetUsers", "RegistrationStatus");
        }
    }
}
