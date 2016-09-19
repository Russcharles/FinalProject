namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Membership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        MembershipDetails = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "MembershipDetailsID", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipType_ID", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipType_ID");
            AddForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_ID" });
            DropColumn("dbo.Customers", "MembershipType_ID");
            DropColumn("dbo.Customers", "MembershipDetailsID");
            DropTable("dbo.MembershipTypes");
        }
    }
}
