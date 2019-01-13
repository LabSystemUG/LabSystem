namespace LabSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "RoleType", c => c.Int(nullable: false));
            DropColumn("dbo.Roles", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "RoleName", c => c.String());
            DropColumn("dbo.Roles", "RoleType");
        }
    }
}
