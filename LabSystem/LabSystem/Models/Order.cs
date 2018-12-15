using System;
using System.Collections.Generic;

namespace LabSystem.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderCreationDate { get; set; }
        public string OrderState { get; set; }
        public double OrderAmount { get; set; }
        public List<Survey> OrderItems { get; set; }
        public int? InvoiceId { get; set; }
    }
}