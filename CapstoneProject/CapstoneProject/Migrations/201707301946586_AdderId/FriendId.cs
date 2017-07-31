namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdderIdFriendId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FriendTables", "AdderId", c => c.String());
            AddColumn("dbo.FriendTables", "FriendId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FriendTables", "FriendId");
            DropColumn("dbo.FriendTables", "AdderId");
        }
    }
}
