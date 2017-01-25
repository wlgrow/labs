using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Kpo4281.Vasilov.Lib
{
    public class EmployeeListSplitFileLoader :IEmployeeListLoader
    {
        
        public EmployeeListSplitFileLoader(string dataFileName)
        {
            _dataFileName = dataFileName;
        }

        private readonly string _dataFileName = null;
        private List<Employee> _employeeList = new List<Employee>();
        private LoadStatus _status = LoadStatus.None;

        public List<Employee> employeeList()
        {
            return _employeeList;
        }
        public LoadStatus status
        {
            get { return _status; }
        }

        private void SplitLine(string source)
        {
            try
            {
                string[] arr = source.Split('|');
                if (arr.Length < 4)
                {
                    _status = LoadStatus.GeneralError;
                    throw new System.IndexOutOfRangeException("В файле в строке не хватает данных");
                }
                Employee employee = new Employee()
                {
                    surname = arr[0],
                    initials = arr[1],
                    birth = Int32.Parse(arr[2]),
                    salary = float.Parse(arr[3], System.Globalization.CultureInfo.InvariantCulture)
                };
                _employeeList.Add(employee);
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(DateTime.Now + " Ошибка: " + ex.Message + "\n");
                _status = LoadStatus.GeneralError;
            }
        }

        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(_dataFileName))
            {
                _status=LoadStatus.FileNameIsEmpty;
                throw new Exception("У файла не может быть пустого имени");
            }
            else if (!File.Exists(_dataFileName))
            {
                _status = LoadStatus.FileNotExists;
                _employeeList = null;
                throw new FileNotFoundException(_dataFileName);
            }

            StreamReader sr = null;
            using (sr = new StreamReader(_dataFileName))
            {
                while (!sr.EndOfStream)
                {
                    //Прочитать очередную строку
                    string str = sr.ReadLine();
                    SplitLine(str);
                }
            }
            if (_status == LoadStatus.None)
            {
                _status = LoadStatus.Success;
            }
        }

    }
}
