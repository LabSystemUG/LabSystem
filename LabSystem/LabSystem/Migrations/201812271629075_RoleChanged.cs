namespace LabSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleChanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Roles", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "UserId", c => c.Int(nullable: false));
        }
    }
}