using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public class EmployeeListTestLoader:IEmployeeListLoader
    {
        public EmployeeListTestLoader()
        {
            _employeeList = new List<Employee>();
        }
        private readonly string _dataFileName = "";
        private List<Employee> _employeeList = null;
        public List<Employee> employeeList()
        {
            return _employeeList;
        }

        private LoadStatus _status = LoadStatus.None;
        public LoadStatus status
        {
            get { return _status; }
        }
        public void Execute()
        {

            {
                Employee employee = new Employee()
                //данная констуркция позволяет инициализировать объект при его создании
                {
                    surname = "Иванов",
                    initials = "И.И.",
                    birth = 1975,
                    salary = 517.50F
                };
                _employeeList.Add(employee);
            }
            {
                Employee employee = new Employee()
                {
                    surname = "Петренко",
                    initials = "П.П.",
                    birth = 1956,
                    salary = 219.10F
                };
                _employeeList.Add(employee);
            }
            {
                Employee employee = new Employee()
                {
                    surname = "Паниковский",
                    initials = "М.С.",
                    birth = 1967,
                    salary = 300.00F
                };
                _employeeList.Add(employee);
            }
            _status = LoadStatus.Success;
        }


    }
}
