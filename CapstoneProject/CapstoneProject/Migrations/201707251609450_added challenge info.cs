namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedchallengeinfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ChallengeName", c => c.String());
            AddColumn("dbo.AspNetUsers", "ChallengeId", c => c.String());
            AddColumn("dbo.AspNetUsers", "StartDate", c => c.String());
            AddColumn("dbo.AspNetUsers", "EndDate", c => c.String());
            AddColumn("dbo.AspNetUsers", "GoalOne", c => c.String());
            AddColumn("dbo.AspNetUsers", "GoalTwo", c => c.String());
            AddColumn("dbo.AspNetUsers", "GoalThree", c => c.String());
            AddColumn("dbo.AspNetUsers", "GoalFour", c => c.String());
            AddColumn("dbo.AspNetUsers", "GoalFive", c => c.String());
            AddColumn("dbo.AspNetUsers", "DescOne", c => c.String());
            AddColumn("dbo.AspNetUsers", "DescTwo", c => c.String());
            AddColumn("dbo.AspNetUsers", "DescThree", c => c.String());
            AddColumn("dbo.AspNetUsers", "DescFour", c => c.String());
            AddColumn("dbo.AspNetUsers", "DescFive", c => c.String());
            AddColumn("dbo.AspNetUsers", "DiffOne", c => c.String());
            AddColumn("dbo.AspNetUsers", "DiffTwo", c => c.String());
            AddColumn("dbo.AspNetUsers", "DiffThree", c => c.String());
            AddColumn("dbo.AspNetUsers", "DiffFour", c => c.String());
            AddColumn("dbo.AspNetUsers", "DiffFive", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DiffFive");
            DropColumn("dbo.AspNetUsers", "DiffFour");
            DropColumn("dbo.AspNetUsers", "DiffThree");
            DropColumn("dbo.AspNetUsers", "DiffTwo");
            DropColumn("dbo.AspNetUsers", "DiffOne");
            DropColumn("dbo.AspNetUsers", "DescFive");
            DropColumn("dbo.AspNetUsers", "DescFour");
            DropColumn("dbo.AspNetUsers", "DescThree");
            DropColumn("dbo.AspNetUsers", "DescTwo");
            DropColumn("dbo.AspNetUsers", "DescOne");
            DropColumn("dbo.AspNetUsers", "GoalFive");
            DropColumn("dbo.AspNetUsers", "GoalFour");
            DropColumn("dbo.AspNetUsers", "GoalThree");
            DropColumn("dbo.AspNetUsers", "GoalTwo");
            DropColumn("dbo.AspNetUsers", "GoalOne");
            DropColumn("dbo.AspNetUsers", "EndDate");
            DropColumn("dbo.AspNetUsers", "StartDate");
            DropColumn("dbo.AspNetUsers", "ChallengeId");
            DropColumn("dbo.AspNetUsers", "ChallengeName");
        }
    }
}
