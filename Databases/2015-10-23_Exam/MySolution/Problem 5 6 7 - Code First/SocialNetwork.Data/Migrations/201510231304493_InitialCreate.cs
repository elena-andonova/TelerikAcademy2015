namespace SocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatMessages",
                c => new
                    {
                        ChatMessageId = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        SendingTime = c.DateTime(nullable: false),
                        SeeingTime = c.DateTime(nullable: false),
                        FriendshipId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Author_UserProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.ChatMessageId)
                .ForeignKey("dbo.UserProfiles", t => t.Author_UserProfileId)
                .ForeignKey("dbo.Friendships", t => t.FriendshipId, cascadeDelete: true)
                .Index(t => t.FriendshipId)
                .Index(t => t.Author_UserProfileId);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserProfileId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserProfileId)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(nullable: false),
                        FileExtension = c.String(nullable: false, maxLength: 4),
                        UserProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfileId, cascadeDelete: true)
                .Index(t => t.UserProfileId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        PostingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        FriendshipId = c.Int(nullable: false, identity: true),
                        ApprovalStatus = c.Boolean(nullable: false),
                        DateOfApproval = c.DateTime(nullable: false),
                        FirstUserProfileId = c.Int(nullable: false),
                        SecondUserProfileId = c.Int(nullable: false),
                        FirstUserProfile_UserProfileId = c.Int(),
                        SecondUserProfile_UserProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.FriendshipId)
                .ForeignKey("dbo.UserProfiles", t => t.FirstUserProfile_UserProfileId)
                .ForeignKey("dbo.UserProfiles", t => t.SecondUserProfile_UserProfileId)
                .Index(t => t.FirstUserProfile_UserProfileId)
                .Index(t => t.SecondUserProfile_UserProfileId);
            
            CreateTable(
                "dbo.PostUserProfiles",
                c => new
                    {
                        Post_PostId = c.Int(nullable: false),
                        UserProfile_UserProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_PostId, t.UserProfile_UserProfileId })
                .ForeignKey("dbo.Posts", t => t.Post_PostId, cascadeDelete: true)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_UserProfileId, cascadeDelete: true)
                .Index(t => t.Post_PostId)
                .Index(t => t.UserProfile_UserProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friendships", "SecondUserProfile_UserProfileId", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "FirstUserProfile_UserProfileId", "dbo.UserProfiles");
            DropForeignKey("dbo.ChatMessages", "FriendshipId", "dbo.Friendships");
            DropForeignKey("dbo.PostUserProfiles", "UserProfile_UserProfileId", "dbo.UserProfiles");
            DropForeignKey("dbo.PostUserProfiles", "Post_PostId", "dbo.Posts");
            DropForeignKey("dbo.Images", "UserProfileId", "dbo.UserProfiles");
            DropForeignKey("dbo.ChatMessages", "Author_UserProfileId", "dbo.UserProfiles");
            DropIndex("dbo.PostUserProfiles", new[] { "UserProfile_UserProfileId" });
            DropIndex("dbo.PostUserProfiles", new[] { "Post_PostId" });
            DropIndex("dbo.Friendships", new[] { "SecondUserProfile_UserProfileId" });
            DropIndex("dbo.Friendships", new[] { "FirstUserProfile_UserProfileId" });
            DropIndex("dbo.Images", new[] { "UserProfileId" });
            DropIndex("dbo.UserProfiles", new[] { "Username" });
            DropIndex("dbo.ChatMessages", new[] { "Author_UserProfileId" });
            DropIndex("dbo.ChatMessages", new[] { "FriendshipId" });
            DropTable("dbo.PostUserProfiles");
            DropTable("dbo.Friendships");
            DropTable("dbo.Posts");
            DropTable("dbo.Images");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.ChatMessages");
        }
    }
}
