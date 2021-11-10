using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Prognosis
    {
        public DateTime Date { get; set; }
        public Branch Branch { get; set; }
        public int Customers { get; set; }
        public int Carts { get; set; }
    }
}
