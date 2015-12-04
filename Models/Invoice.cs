using System;

namespace ControlTester.Models
{
    public enum InvoiceStatus { Paid, Unpaid, Overdue }

    public class Invoice
    {
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public decimal Amount { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; }
    }
}

