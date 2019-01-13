namespace LabSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Roles", new[] { "Employee_Id" });
            RenameColumn(table: "dbo.Roles", name: "Employee_Id", newName: "EmployeeId");
            AlterColumn("dbo.Roles", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Roles", "EmployeeId");
            AddForeignKey("dbo.Roles", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Roles", new[] { "EmployeeId" });
            AlterColumn("dbo.Roles", "EmployeeId", c => c.Int());
            RenameColumn(table: "dbo.Roles", name: "EmployeeId", newName: "Employee_Id");
            CreateIndex("dbo.Roles", "Employee_Id");
            AddForeignKey("dbo.Roles", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
