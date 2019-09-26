namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "email", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "password");
            DropColumn("dbo.Customers", "email");
        }
    }
}
