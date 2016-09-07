namespace Dementor.DAL.Database
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        GloberMood_Id = c.Int(),
                        Mentee_Id = c.Guid(),
                        Mentor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Moods", t => t.GloberMood_Id)
                .ForeignKey("dbo.Globers", t => t.Mentee_Id)
                .ForeignKey("dbo.Globers", t => t.Mentor_Id)
                .Index(t => t.GloberMood_Id)
                .Index(t => t.Mentee_Id)
                .Index(t => t.Mentor_Id);
            
            CreateTable(
                "dbo.Moods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Globers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        TechnicalLeader = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mentorings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Mentee_Id = c.Guid(),
                        Mentor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Globers", t => t.Mentee_Id)
                .ForeignKey("dbo.Globers", t => t.Mentor_Id)
                .Index(t => t.Mentee_Id)
                .Index(t => t.Mentor_Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mentorings", "Mentor_Id", "dbo.Globers");
            DropForeignKey("dbo.Mentorings", "Mentee_Id", "dbo.Globers");
            DropForeignKey("dbo.Feedbacks", "Mentor_Id", "dbo.Globers");
            DropForeignKey("dbo.Feedbacks", "Mentee_Id", "dbo.Globers");
            DropForeignKey("dbo.Feedbacks", "GloberMood_Id", "dbo.Moods");
            DropIndex("dbo.Mentorings", new[] { "Mentor_Id" });
            DropIndex("dbo.Mentorings", new[] { "Mentee_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Mentor_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Mentee_Id" });
            DropIndex("dbo.Feedbacks", new[] { "GloberMood_Id" });
            DropTable("dbo.Reports");
            DropTable("dbo.Mentorings");
            DropTable("dbo.Globers");
            DropTable("dbo.Moods");
            DropTable("dbo.Feedbacks");
        }
    }
}
