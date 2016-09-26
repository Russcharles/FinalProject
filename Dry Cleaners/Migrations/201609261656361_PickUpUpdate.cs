namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PickUpUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PickUps",
                c => new
                    {
                        ID = c.Byte(nullable: false),
                        DayOfWeek = c.String(),
                        PickUpTime = c.String(),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PickUps");
        }
    }
}
