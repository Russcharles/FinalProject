namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCustomerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DryCleanerStores",
                c => new
                    {
                        ID = c.Byte(nullable: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "DryCleanerStoresID", c => c.Byte(nullable: true));
            CreateIndex("dbo.Customers", "DryCleanerStoresID");
            AddForeignKey("dbo.Customers", "DryCleanerStoresID", "dbo.DryCleanerStores", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DryCleanerStoresID", "dbo.DryCleanerStores");
            DropIndex("dbo.Customers", new[] { "DryCleanerStoresID" });
            DropColumn("dbo.Customers", "DryCleanerStoresID");
            DropTable("dbo.DryCleanerStores");
        }
    }
}
