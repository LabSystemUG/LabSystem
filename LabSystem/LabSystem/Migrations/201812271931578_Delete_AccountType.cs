namespace LabSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_AccountType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AccountType");
            DropColumn("dbo.Employees", "AccountType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "AccountType", c => c.String());
            AddColumn("dbo.Customers", "AccountType", c => c.String());
        }
    }
}
