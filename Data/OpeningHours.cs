using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OpeningHours
    {
        //Will this work?
        public WeekDay WeekDay{ get; set; }
        public Branch Branch { get; set; }
        public DateTime From{ get; set; }
        public DateTime To{ get; set; }
    }
}
