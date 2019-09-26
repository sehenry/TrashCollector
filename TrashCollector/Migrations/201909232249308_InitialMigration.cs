namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "trashDay", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "frequencyOfPickUp", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "address", c => c.String(nullable: false));
            DropColumn("dbo.Customers", "emailAddress");
            DropColumn("dbo.Customers", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "password", c => c.String());
            AddColumn("dbo.Customers", "emailAddress", c => c.String());
            AlterColumn("dbo.Customers", "address", c => c.String());
            AlterColumn("dbo.Customers", "lastName", c => c.String());
            AlterColumn("dbo.Customers", "firstName", c => c.String());
            DropColumn("dbo.Customers", "frequencyOfPickUp");
            DropColumn("dbo.Customers", "trashDay");
        }
    }
}
