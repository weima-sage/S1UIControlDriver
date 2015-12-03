using System;

namespace ControlTester.Models
{
    public enum InfoStatus
    {
        Paid,
        Unpaid,
        Overdue
    }

    public class Entity
    {
        public Entity() { }

        public string Title { get; set; }
        public string Subtitle { get; set; }
        public decimal Amount { get; set; }
        public InfoStatus InfoStatus { get; set; }
    }
}

