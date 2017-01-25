using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public class EmployeeTestFactory: IEmployeeFactory
    {
        public IEmployeeListLoader createEmployeeListLoader()
        {
            return new EmployeeListTestLoader();
        }

        public IEmployeeListSaver createEmployeeListSaver()
        {
            return new EmployeeListTestSaver();
        }
    }
}
