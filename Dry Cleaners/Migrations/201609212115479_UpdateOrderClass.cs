namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Shirt");
            DropColumn("dbo.Orders", "Pants");
            DropColumn("dbo.Orders", "Suit");
            DropColumn("dbo.Orders", "Dress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Dress", c => c.String());
            AddColumn("dbo.Orders", "Suit", c => c.String());
            AddColumn("dbo.Orders", "Pants", c => c.String());
            AddColumn("dbo.Orders", "Shirt", c => c.String());
        }
    }
}
