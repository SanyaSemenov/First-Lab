using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class City
    {
        public Int32 Code { get; set; }
        public String Name { get; set; }
        public Int32 SubjectID { get; set; }
        public Subject SubjectName { get; set; }
        public List<Street> Streets { get; set; }
    }
}
