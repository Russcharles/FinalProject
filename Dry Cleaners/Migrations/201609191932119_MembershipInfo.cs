namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipInfo : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (ID, MembershipDetails) VALUES (1, 'Monthly - $49.99') ");
            Sql("INSERT INTO MembershipTypes (ID, MembershipDetails) VALUES (2, '3 Months - $120.00') ");
            Sql("INSERT INTO MembershipTypes (ID, MembershipDetails) VALUES (3, '6 Months - $180.00') ");
            Sql("INSERT INTO MembershipTypes (ID, MembershipDetails) VALUES (4, 'Yearly - $240.00') ");
            
        }
        
        public override void Down()
        {
        }
    }
}
