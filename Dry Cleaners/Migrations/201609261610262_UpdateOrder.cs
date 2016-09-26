namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "EmailAddress");
        }
    }
}
