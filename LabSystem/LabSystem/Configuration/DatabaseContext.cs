using LabSystem.Models;
using System.Data.Entity;

namespace LabSystem.Configuration
{
    public class DatabaseContext : DbContext
    {
        
        public DatabaseContext() : base("LabSystemConnection")
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Report> Reports{ get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<Survey> Surveys { get; set; }
    }
}