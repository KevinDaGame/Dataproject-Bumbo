using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Branch
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public Employee Manager { get; set; }
        public String StreetName { get; set; }
        //string because for example 21B is possible
        public String HouseNumber { get; set; }
        public String PostalCode { get; set; }
        public String City { get; set; }


    }
}
