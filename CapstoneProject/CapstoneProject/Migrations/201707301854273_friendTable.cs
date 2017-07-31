namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class friendTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "friends_AdderId", c => c.String());
            AddColumn("dbo.AspNetUsers", "friends_FriendId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "friends_FriendId");
            DropColumn("dbo.AspNetUsers", "friends_AdderId");
        }
    }
}
