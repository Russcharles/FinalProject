namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulationKioskLocationsAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO KioskLocations (ID, KioskBuilding) VALUES (1, 'Building A') ");
            Sql("INSERT INTO KioskLocations (ID, KioskBuilding) VALUES (2, 'Building B') ");
            Sql("INSERT INTO KioskLocations (ID, KioskBuilding) VALUES (3, 'Building C') ");
            Sql("INSERT INTO KioskLocations (ID, KioskBuilding) VALUES (4, 'Building D') ");
            Sql("INSERT INTO KioskLocations (ID, KioskBuilding) VALUES (5, 'Building E') ");
        }
        
        public override void Down()
        {
        }
    }
}
