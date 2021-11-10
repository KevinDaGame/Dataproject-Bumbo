using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Surcharge
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public DateTime From{ get; set; }
        public DateTime To{ get; set; }
    }
}
