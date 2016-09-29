namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "PhoneNumber", c => c.String());
            DropColumn("dbo.Orders", "EmailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "EmailAddress", c => c.String());
            DropColumn("dbo.Orders", "PhoneNumber");
        }
    }
}
