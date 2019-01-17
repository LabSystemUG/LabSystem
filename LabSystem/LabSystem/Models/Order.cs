using System;

namespace LabSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int LaboratoryId { get; set; }
        public DateTime OrderCreationDate { get; set; }
        public string OrderState { get; set; }
        public double OrderAmount { get; set; }
        public int? InvoiceId { get; set; }
        public int EmployeeId { get; set; }
    }
}