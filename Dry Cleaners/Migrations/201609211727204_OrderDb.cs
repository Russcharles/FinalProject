namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Shirt = c.String(),
                        AmountOfShirts = c.Int(nullable: false),
                        Pants = c.String(),
                        AmountOfPants = c.Int(nullable: false),
                        Suit = c.String(),
                        AmountOfSuits = c.Int(nullable: false),
                        Dress = c.String(),
                        AmountOfDresses = c.Int(nullable: false),
                        CommentSection = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
