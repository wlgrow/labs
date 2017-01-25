using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public class EmployeeListTestSaver: IEmployeeListSaver
    {
        private SaveStatus _status = SaveStatus.None;
        public SaveStatus getStatus()
        {return _status;}

        public void ExecuteSave(List<Employee> person)
        {
            _status=SaveStatus.Success;
        }

    }
}
