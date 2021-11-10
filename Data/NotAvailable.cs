using System;

namespace Data
{
    class NotAvailable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public BranchEmployee BranchEmployee { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool Accepted { get; set; }
        public bool Confirmed { get; set; }

    }
}
