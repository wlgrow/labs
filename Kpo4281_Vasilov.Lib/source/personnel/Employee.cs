using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public class Employee
    {
        public Employee()
        {
            surname = "";
            initials = "";
            birth = 0;
            salary = 0;
        }
        public string surname { get; set; }
        public string initials { get; set; }
        public int birth { get; set; }
        public float salary { get; set; }
    }
}
