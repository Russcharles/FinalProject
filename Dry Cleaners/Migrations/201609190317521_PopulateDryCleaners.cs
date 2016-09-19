namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDryCleaners : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DryCleanerStores (ID, CompanyName) VALUES (1, 'Alba Dry Cleaners') ");
            Sql("INSERT INTO DryCleanerStores (ID, CompanyName) VALUES (2, 'Very Dry Cleaners') ");
            Sql("INSERT INTO DryCleanerStores (ID, CompanyName) VALUES (3, 'Super Dry Cleaners') ");
            Sql("INSERT INTO DryCleanerStores (ID, CompanyName) VALUES (4, 'Sunset Dry Cleaners') ");
        }
        
        public override void Down()
        {
        }
    }
}
