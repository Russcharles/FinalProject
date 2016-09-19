namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDryCleanerStores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DryCleanerStores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "DryCleanerStoresID", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "DryCleanerStores_ID", c => c.Int());
            CreateIndex("dbo.Customers", "DryCleanerStores_ID");
            AddForeignKey("dbo.Customers", "DryCleanerStores_ID", "dbo.DryCleanerStores", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DryCleanerStores_ID", "dbo.DryCleanerStores");
            DropIndex("dbo.Customers", new[] { "DryCleanerStores_ID" });
            DropColumn("dbo.Customers", "DryCleanerStores_ID");
            DropColumn("dbo.Customers", "DryCleanerStoresID");
            DropTable("dbo.DryCleanerStores");
        }
    }
}
