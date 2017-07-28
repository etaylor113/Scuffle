namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfriendtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ApplicationUserFriendTables",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        FriendTable_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.FriendTable_id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.FriendTables", t => t.FriendTable_id, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.FriendTable_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserFriendTables", "FriendTable_id", "dbo.FriendTables");
            DropForeignKey("dbo.ApplicationUserFriendTables", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserFriendTables", new[] { "FriendTable_id" });
            DropIndex("dbo.ApplicationUserFriendTables", new[] { "ApplicationUser_Id" });
            DropTable("dbo.ApplicationUserFriendTables");
            DropTable("dbo.FriendTables");
        }
    }
}
