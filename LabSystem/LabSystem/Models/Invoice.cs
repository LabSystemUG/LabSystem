using System;
using System.Collections.Generic;

namespace LabSystem.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceSignature { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Order> OrderList { get; set; }
        public int CustomerId { get; set; }
    }
}