namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrashWorker : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrashWorkers",
                c => new
                    {
                        TrashWorkerId = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false),
                        lastName = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        routeZipCode = c.String(nullable: false),
                        trashWorkDay = c.String(nullable: false),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TrashWorkerId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrashWorkers", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.TrashWorkers", new[] { "ApplicationUserId" });
            DropTable("dbo.TrashWorkers");
        }
    }
}
