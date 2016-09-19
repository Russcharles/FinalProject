namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDryCleanerStoresAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "DryCleanerStores_ID", "dbo.DryCleanerStores");
            DropIndex("dbo.Customers", new[] { "DryCleanerStores_ID" });
            DropColumn("dbo.Customers", "DryCleanerStoresID");
            DropColumn("dbo.Customers", "DryCleanerStores_ID");
            DropTable("dbo.DryCleanerStores");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DryCleanerStores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "DryCleanerStores_ID", c => c.Int());
            AddColumn("dbo.Customers", "DryCleanerStoresID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "DryCleanerStores_ID");
            AddForeignKey("dbo.Customers", "DryCleanerStores_ID", "dbo.DryCleanerStores", "ID");
        }
    }
}
