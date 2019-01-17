using LabSystem.Models;
using System.Collections.Generic;

namespace LabSystem.ViewModels
{
    public class VM_Employee
    {
        public Employee EmployeeData { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Order>  Orders { get; set; }
        public Laboratory Laboratory { get; set; }
        public List<Report> Reports { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<Sample> Samples { get; set; }
        public List<Survey> Surveys { get; set; }
    }
}