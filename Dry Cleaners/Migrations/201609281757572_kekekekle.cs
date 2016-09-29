namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kekekekle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PickUps", "Date", c => c.String());
            AddColumn("dbo.PickUps", "Time", c => c.String());
            AddColumn("dbo.PickUps", "PhoneNumber", c => c.String());
            DropColumn("dbo.PickUps", "DayOfWeek");
            DropColumn("dbo.PickUps", "PickUpTime");
            DropColumn("dbo.PickUps", "EmailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PickUps", "EmailAddress", c => c.String());
            AddColumn("dbo.PickUps", "PickUpTime", c => c.String());
            AddColumn("dbo.PickUps", "DayOfWeek", c => c.String());
            DropColumn("dbo.PickUps", "PhoneNumber");
            DropColumn("dbo.PickUps", "Time");
            DropColumn("dbo.PickUps", "Date");
        }
    }
}
