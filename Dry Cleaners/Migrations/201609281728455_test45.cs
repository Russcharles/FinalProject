namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test45 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PickUps");
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.PickUps", "ID", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.PickUps", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PickUps", "Time", c => c.String());
            AddColumn("dbo.PickUps", "Date", c => c.String());
            AddColumn("dbo.Orders", "PhoneNumber2", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "FirstName2", c => c.String());
            DropPrimaryKey("dbo.PickUps");
            AlterColumn("dbo.PickUps", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
            DropColumn("dbo.PickUps", "PickUpTime");
            DropColumn("dbo.PickUps", "DayOfWeek");
            DropColumn("dbo.Orders", "EmailAddress");
            AddPrimaryKey("dbo.PickUps", "ID");
        }
    }
}
