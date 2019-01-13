namespace LabSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Survey_Sample_Role_Report_Order_Laboratory_Invoice_Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AccountType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleName = c.String(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        InvoiceSignature = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Laboratories",
                c => new
                    {
                        LaboratoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Voivodeship = c.String(),
                        Commune = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Street = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.LaboratoryId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.String(nullable: false, maxLength: 128),
                        LaboratoryId = c.Int(nullable: false),
                        OrderCreationDate = c.DateTime(nullable: false),
                        OrderState = c.String(),
                        OrderAmount = c.Double(nullable: false),
                        InvoiceId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        WorkTime = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        OperationCosts = c.Int(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId);
            
            CreateTable(
                "dbo.Samples",
                c => new
                    {
                        SampleId = c.Int(nullable: false, identity: true),
                        SurveyId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SampleId);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        EstimatedTime = c.Int(nullable: false),
                        AttempsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Roles", new[] { "Employee_Id" });
            DropTable("dbo.Surveys");
            DropTable("dbo.Samples");
            DropTable("dbo.Reports");
            DropTable("dbo.Orders");
            DropTable("dbo.Laboratories");
            DropTable("dbo.Invoices");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
        }
    }
}
