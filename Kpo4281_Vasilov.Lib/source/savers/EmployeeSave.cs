using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo4281.Vasilov.Lib
{
    public class EmployeeListSplitFileSaver: IEmployeeListSaver
    {
        private SaveStatus _status = SaveStatus.None;
        public SaveStatus getStatus()
        {
            return _status;
        }

        public void ExecuteSave(List<Employee> person)
        {
            if (string.IsNullOrWhiteSpace(AppGlobalSettings.dataFileName))
            {
                _status = SaveStatus.FileNameIsEmpty;
                throw new Exception("У файла не может быть пустого имени");
            }

            if (!File.Exists(AppGlobalSettings.dataFileName))
            {
                _status = SaveStatus.FileNotExist;
                throw new FileNotFoundException(AppGlobalSettings.dataFileName);
            }

            using (var sr = File.CreateText(AppGlobalSettings.dataFileName))
            {
                foreach (Employee item in person)
                {
                    try
                    {
                        sr.WriteLine(string.Format("{0}|{1}|{2}|{3}", item.surname, item.initials, item.birth, item.salary));
                    }
                    catch (Exception ex)
                    {
                        _status = SaveStatus.GeneralError;
                        LogUtility.ErrorLog(DateTime.Now + " Ошибка: " + ex.Message + "\n");
                    }
                }
            }

            if (_status == SaveStatus.None)
            {
                _status = SaveStatus.Success;
            }
        }
    }
}
