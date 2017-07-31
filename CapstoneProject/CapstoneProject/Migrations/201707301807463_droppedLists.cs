namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droppedLists : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ApplicationUserFriendTables", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUserFriendTables", "FriendTable_id", "dbo.FriendTables");
            DropIndex("dbo.ApplicationUserFriendTables", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUserFriendTables", new[] { "FriendTable_id" });
            DropTable("dbo.ApplicationUserFriendTables");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ApplicationUserFriendTables",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        FriendTable_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.FriendTable_id });
            
            CreateIndex("dbo.ApplicationUserFriendTables", "FriendTable_id");
            CreateIndex("dbo.ApplicationUserFriendTables", "ApplicationUser_Id");
            AddForeignKey("dbo.ApplicationUserFriendTables", "FriendTable_id", "dbo.FriendTables", "id", cascadeDelete: true);
            AddForeignKey("dbo.ApplicationUserFriendTables", "ApplicationUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
