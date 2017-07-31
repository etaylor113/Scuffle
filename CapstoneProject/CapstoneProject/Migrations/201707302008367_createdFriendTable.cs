namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdFriendTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        AdderName = c.String(),
                        FriendName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.AspNetUsers", "friends_id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "friends_id");
            AddForeignKey("dbo.AspNetUsers", "friends_id", "dbo.Friends", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "friends_id", "dbo.Friends");
            DropIndex("dbo.AspNetUsers", new[] { "friends_id" });
            DropColumn("dbo.AspNetUsers", "friends_id");
            DropTable("dbo.Friends");
        }
    }
}
