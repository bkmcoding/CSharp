using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gross_Pay
{
    public partial class viewEmployees : UserControl
    {
        public viewEmployees()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void UpdateView(List<object> employees)
        {
            dataGridView.Rows.Clear();
            int i = 0;
            foreach (Employee employee in employees)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = employee.Fname;
                dataGridView.Rows[i].Cells[1].Value = employee.Lname;
                dataGridView.Rows[i].Cells[2].Value = employee.HWage;
                dataGridView.Rows[i].Cells[3].Value = employee.HWorked;
                dataGridView.Rows[i].Cells[4].Value = employee.Overtime;
                dataGridView.Rows[i].Cells[5].Value = employee.Wage;
                i++;
            }
        }

    }
}
