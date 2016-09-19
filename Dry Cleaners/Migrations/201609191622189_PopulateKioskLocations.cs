namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateKioskLocations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KioskLocations",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        KioskBuilding = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "KioskBuildingID", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "KioskLocations_ID", c => c.Byte());
            CreateIndex("dbo.Customers", "KioskLocations_ID");
            AddForeignKey("dbo.Customers", "KioskLocations_ID", "dbo.KioskLocations", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "KioskLocations_ID", "dbo.KioskLocations");
            DropIndex("dbo.Customers", new[] { "KioskLocations_ID" });
            DropColumn("dbo.Customers", "KioskLocations_ID");
            DropColumn("dbo.Customers", "KioskBuildingID");
            DropTable("dbo.KioskLocations");
        }
    }
}
