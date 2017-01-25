using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public class EmployeeSplitFileFactory: IEmployeeFactory
    {
        public IEmployeeListLoader createEmployeeListLoader()
        {
            return new EmployeeListSplitFileLoader(AppGlobalSettings.dataFileName);
        }

        public IEmployeeListSaver createEmployeeListSaver()
        {
            return new EmployeeListSplitFileSaver();
        }
    }
}
