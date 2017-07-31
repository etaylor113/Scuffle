namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdderIdFriendId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendsModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        AdderId = c.String(),
                        FriendId = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FriendsModels");
        }
    }
}
