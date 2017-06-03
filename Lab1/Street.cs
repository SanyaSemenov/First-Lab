using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Street
    {
        public Int32 Code { get; set; }
        public String Name { get; set; }
        public Int32 CityID { get; set; }
        public City CityName { get; set; }
        public Street(String aName)
        {
            Name = aName;
        }
    }
}
