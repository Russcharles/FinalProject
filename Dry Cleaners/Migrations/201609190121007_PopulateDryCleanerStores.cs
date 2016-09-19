namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDryCleanerStores : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DryCleanerStores (CompanyName) VALUES ('Soap Box Cleaners')");
            Sql("INSERT INTO DryCleanerStores (CompanyName) VALUES ('Alba Dry Cleaners')");
            Sql("INSERT INTO DryCleanerStores (CompanyName) VALUES ('A1 Dry Cleaners')");
            Sql("INSERT INTO DryCleanerStores (CompanyName) VALUES ('Very Dry Cleaners')");
        }
        
        public override void Down()
        {
        }
    }
}
