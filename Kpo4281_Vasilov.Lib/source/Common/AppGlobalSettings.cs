using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4281.Utility;

namespace Kpo4281.Vasilov.Lib
{
    public class AppGlobalSettings
    {
        private static string _logPath = null;
        public static string logPath
        {
            get{return _logPath;}
        }

        private static string _dataFileName = null;
        public static string dataFileName
        {
            get { return _dataFileName;}
        }

        private static IEmployeeFactory _employeeFactory = null;
        public static IEmployeeFactory EmployeeFactory
        {
            get { return _employeeFactory; }
        }

        private static int _unitTest = 0;
        public static int unitTest
        {
            get { return _unitTest;}
        }

        public static void Init()
        {
            AppConfigUtility conf = new AppConfigUtility();
            _logPath = conf.AppSettings("logPath");
            _dataFileName = conf.AppSettings("dataFileName");
            _unitTest = Int32.Parse(conf.AppSettings("unitTest"));

            if (_unitTest==0)
            {
                _employeeFactory = new EmployeeSplitFileFactory();
            }
            else
            {
                _employeeFactory = new EmployeeTestFactory();
            }


        }

    }
}
