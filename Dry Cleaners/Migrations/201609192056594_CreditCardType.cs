namespace Dry_Cleaners.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditCardType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CreditCardInfoes (ID, CreditCardType, CreditCardNumber, CVC, Zipcode) VALUES (1, 'Visa', 0, 0, 0) ");
            Sql("INSERT INTO CreditCardInfoes (ID, CreditCardType, CreditCardNumber, CVC, Zipcode) VALUES (2, 'MasterCard', 0, 0, 0) ");
            Sql("INSERT INTO CreditCardInfoes (ID, CreditCardType, CreditCardNumber, CVC, Zipcode) VALUES (3, 'Discover', 0, 0, 0) ");
        }
        
        public override void Down()
        {
        }
    }
}
