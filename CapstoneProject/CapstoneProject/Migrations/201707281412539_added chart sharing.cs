namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedchartsharing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ChartShared", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ChartShared");
        }
    }
}
