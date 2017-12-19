namespace TestPatterns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesProducts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "InternalPerc", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "ImportPerc", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "ManufactoryPerc", c => c.Double(nullable: false));
            DropColumn("dbo.Products", "Internal");
            DropColumn("dbo.Products", "Import");
            DropColumn("dbo.Products", "Manufactory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Manufactory", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Import", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Internal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "ManufactoryPerc");
            DropColumn("dbo.Products", "ImportPerc");
            DropColumn("dbo.Products", "InternalPerc");
        }
    }
}
