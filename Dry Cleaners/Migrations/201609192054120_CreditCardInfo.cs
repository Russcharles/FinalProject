namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditCardInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCardInfoes",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        CreditCardType = c.String(),
                        CreditCardNumber = c.Int(nullable: true),
                        CVC = c.Int(nullable: true),
                        Zipcode = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "CreditCardTypeID", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "CreditCardInfo_ID", c => c.Byte());
            CreateIndex("dbo.Customers", "CreditCardInfo_ID");
            AddForeignKey("dbo.Customers", "CreditCardInfo_ID", "dbo.CreditCardInfoes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CreditCardInfo_ID", "dbo.CreditCardInfoes");
            DropIndex("dbo.Customers", new[] { "CreditCardInfo_ID" });
            DropColumn("dbo.Customers", "CreditCardInfo_ID");
            DropColumn("dbo.Customers", "CreditCardTypeID");
            DropTable("dbo.CreditCardInfoes");
        }
    }
}
