
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class SchoolHours
    {
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
        public TimeSpan Time { get; set; }
    }
}
