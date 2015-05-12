using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    
    public partial class EmployeeInformationUi : Form
    {
        Employee aEmployee = new Employee();
        public EmployeeInformationUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
           
            aEmployee.ID = idTextBox.Text;
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Salary = Convert.ToDouble(salaryTextBox.Text);
            MessageBox.Show("Employee Information." + "\nId: " + aEmployee.ID +
     "\nName: " + aEmployee.Name + "\nSalary: " + aEmployee.Salary);
            ClearEmployeeInformation();

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aEmployee.ID;
            nameTextBox.Text = aEmployee.Name;
            salaryTextBox.Text = aEmployee.Salary.ToString();
        }

        private void ClearEmployeeInformation()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }
    }
}
