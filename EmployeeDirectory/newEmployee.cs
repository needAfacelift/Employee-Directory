using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDirectory
{
    public partial class newEmployee : Form
    {      
        public newEmployee()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            VariablesAndFunctions.commandType = "add";
            string mySql = string.Empty;
            string first = txt_First.Text;
            string last = txt_Last.Text;
            string title = txt_Title.Text;
            mySql = "insert into Users (FirstName, LastName, Title) values (@fN, @lN, @t)";

            try
            {
                using (SqlConnection myConn = new SqlConnection(VariablesAndFunctions.connectionString))
                {
                    myConn.Open();

                    using (SqlCommand myCommand = new SqlCommand(mySql, myConn))
                    {
                        myCommand.Parameters.AddWithValue("@fN", first);
                        myCommand.Parameters.AddWithValue("@lN", last);
                        myCommand.Parameters.AddWithValue("@t", title);
                        myCommand.ExecuteNonQuery();
                    }

                    myConn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
