using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4281.Vasilov.Lib;

namespace Kpo4281.Vasilov.Main
{
    public partial class FrmMain : Form
    {
        private List<Employee> _employeeList = null;
        private BindingSource _bsEmployees = new BindingSource();
        
        private string _status;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            IEmployeeListLoader loader = AppGlobalSettings.EmployeeFactory.createEmployeeListLoader();

            try
            {
                loader.Execute();

                _employeeList = loader.employeeList();
                _bsEmployees.DataSource = _employeeList;
                dgvEmployees.DataSource = _bsEmployees;

                _status = loader.status.ToString();
                toolStripStatus.Text = _status.ToString();
            }

            //обработка остальных исключений
            catch (Exception ex)
            {
                _status = loader.status.ToString();
                toolStripStatus.Text = _status.ToString();
                MessageBox.Show("Ошибка: " + ex.Message);
                LogUtility.ErrorLog(DateTime.Now + " Ошибка: " + ex.Message + "\n");                
            }
        }

        private void mnOpenEmployee_Click(object sender, EventArgs e)
        {
            //Создать экземпляр формы
            FrmEmployee frmEmployee = new FrmEmployee();
            try
            {
                //Задать ссылку на текущий объект в таблицы
                var employee = (Employee)_bsEmployees.Current;
                frmEmployee.SetEmployee(employee);
                //открыть форму в модальном режиме
                frmEmployee.ShowDialog();

                IEmployeeListSaver saver = AppGlobalSettings.EmployeeFactory.createEmployeeListSaver();
                saver.ExecuteSave(_employeeList);

                this.Refresh();
            }

            //обработка остальных исключений
            catch (Exception ex)
            {
                
                MessageBox.Show("Ошибка: " + ex.Message);
                LogUtility.ErrorLog(DateTime.Now + " Ошибка: " + ex.Message + "\n");
                
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
