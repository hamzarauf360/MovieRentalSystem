namespace Movie_Rental_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubToNewsLetter");
        }
    }
}
