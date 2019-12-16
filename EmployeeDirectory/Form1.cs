using System;
using System.Windows.Forms;

namespace EmployeeDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct employeeData
        {
            public static int id;
            public static string fn;
            public static string ln;
            public static string title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.employeesDataSet2.Users);
            gv_employee.Columns[0].Width = 45;

        }

        private void gv_employee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rIndex = e.RowIndex;
            employeeData.id = int.Parse(gv_employee.Rows[rIndex].Cells[0].Value.ToString());
            employeeData.fn = gv_employee.Rows[rIndex].Cells[1].Value.ToString();
            employeeData.ln = gv_employee.Rows[rIndex].Cells[2].Value.ToString();
            employeeData.title = gv_employee.Rows[rIndex].Cells[3].Value.ToString();
            
            details d = new details();
            d.ShowDialog();

            if(VariablesAndFunctions.commandType == "update")
            {
                this.usersTableAdapter.Fill(employeesDataSet2.Users);
                gv_employee.Refresh();
                MessageBox.Show("The listing for " + employeeData.fn + " " + employeeData.ln + " has been updated.");
            }
            else if(VariablesAndFunctions.commandType == "delete")
            {
                this.usersTableAdapter.Fill(employeesDataSet2.Users);
                gv_employee.Refresh();
                MessageBox.Show("The listing for " + employeeData.fn + " " + employeeData.ln + " has been deleted.");
            }

            VariablesAndFunctions.commandType = string.Empty;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            newEmployee nE = new newEmployee();
            nE.ShowDialog();

            if(VariablesAndFunctions.commandType == "add")
            {
                this.usersTableAdapter.Fill(employeesDataSet2.Users);
                gv_employee.Refresh();
                MessageBox.Show("Your new employee was added to the listing.");
            }

            VariablesAndFunctions.commandType = string.Empty;
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.ShowDialog();
        }
    }
}
