using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public interface IEmployeeFactory
    {
        IEmployeeListLoader createEmployeeListLoader();
        IEmployeeListSaver createEmployeeListSaver();
    }
}
