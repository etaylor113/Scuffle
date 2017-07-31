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
            AddColumn("dbo.AspNetUsers", "friendTable_id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "friendTable_id");
            AddForeignKey("dbo.AspNetUsers", "friendTable_id", "dbo.FriendTables", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "friendTable_id", "dbo.FriendTables");
            DropIndex("dbo.AspNetUsers", new[] { "friendTable_id" });
            DropColumn("dbo.AspNetUsers", "friendTable_id");
            DropColumn("dbo.FriendTables", "FriendId");
            DropColumn("dbo.FriendTables", "AdderId");
        }
    }
}
