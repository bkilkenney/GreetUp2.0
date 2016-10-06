namespace GreetUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(),
                        Details = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        NumOfRSVP = c.Int(nullable: false),
                        EventTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EventTypes", t => t.EventTypeID, cascadeDelete: true)
                .Index(t => t.EventTypeID);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventTypeID", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EventTypeID" });
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Attendees");
        }
    }
}
