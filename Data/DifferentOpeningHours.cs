using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class DifferentOpeningHours
    {
        public DateTime Date { get; set; }
        public Branch Branch { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Reason { get; set; }
    }
}
