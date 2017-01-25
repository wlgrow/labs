using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public enum SaveStatus
    {
        None=0,
        Success=1,
        FileNameIsEmpty=-1,
        FileNotExist=-2,
        GeneralError=-100
    }
    public interface IEmployeeListSaver
    {
        SaveStatus getStatus();
        void ExecuteSave(List<Employee> employeeList);
    }
}
