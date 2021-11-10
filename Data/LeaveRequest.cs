using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class LeaveRequest
    {
        public int Id { get; set; }
        public BranchEmployee BranchEmployee { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime SubmissionDate { get; set; }
        public String Reason { get; set; }
        public String Description { get; set; }
        public bool Accepted { get; set; }

    }
}
