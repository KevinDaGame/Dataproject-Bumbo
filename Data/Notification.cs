using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Notification
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Branch Branch { get; set; }
        public String Title { get; set; }
        public String Message { get; set; }

    }
}
