using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Street
    {
        public String Name { get; set; }
        public City CityName { get; set; }
        public Street(String name)
        {
            Name = name;
        }
    }
}
