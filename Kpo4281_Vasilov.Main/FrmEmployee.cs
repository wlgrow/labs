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
    public partial class FrmEmployee : Form
    {
        
        
        private Employee _employee = null;
        public Employee employee
        {
            get { return _employee; }
        }
        public void SetEmployee(Employee employee)
        {
            //инициализировать скрытое поля класса
            this._employee = employee;
            //присвоить значение данных сотрудника элементам редактирования
            this.textBoxSurname.Text = _employee.surname;
            this.textBoxInitials.Text = _employee.initials;
            this.textBoxBirth.Text = _employee.birth.ToString();
            this.textBoxSalary.Text = _employee.salary.ToString();
        }

        public FrmEmployee()
        {
            InitializeComponent();
            //_employee = null;
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }


        private void FrmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _employee.surname = textBoxSurname.Text;
                _employee.initials = textBoxInitials.Text;
                _employee.birth = Int32.Parse(textBoxBirth.Text);
                _employee.salary = float.Parse(textBoxSalary.Text, System.Globalization.CultureInfo.InvariantCulture);

                if (!EmployeeControl.InfoControl(_employee))
                {
                    throw new Exception("Внесены неверные значения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(DateTime.Now + " Ошибка: " + ex.Message + "\n");
                e.Cancel = true;
            }
        }

        private void FrmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
