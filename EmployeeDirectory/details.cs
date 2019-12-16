using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDirectory
{
    public partial class details : Form
    {
        public details()
        {
            InitializeComponent();
        }

        private void details_Load(object sender, EventArgs e)
        {
            txt_Id.Text = Form1.employeeData.id.ToString();
            txt_FirstName.Text = Form1.employeeData.fn;
            txt_LastName.Text = Form1.employeeData.ln;
            txt_Title.Text = Form1.employeeData.title;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_FirstName.Enabled = true;
            txt_LastName.Enabled = true;
            txt_Title.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_FirstName.Enabled = false;
            txt_LastName.Enabled = false;
            txt_Title.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            VariablesAndFunctions.commandType = string.Empty;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            VariablesAndFunctions.commandType = "update";
            string mySql = string.Empty;
            string ID = txt_Id.Text;
            string first = txt_FirstName.Text;
            string last = txt_LastName.Text;
            string title = txt_Title.Text;

            mySql = "Update Users set FirstName = @fN, LastName = @lN, Title = @t where Id = @i";

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
                        myCommand.Parameters.AddWithValue("@i", ID);
                        myCommand.ExecuteNonQuery();
                    }

                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain you want to delete this listing?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                VariablesAndFunctions.commandType = "delete";
                string mySql = string.Empty;
                string ID = txt_Id.Text;

                mySql = "delete from Users where Id = @i";

                try
                {
                    using (SqlConnection myConn = new SqlConnection(VariablesAndFunctions.connectionString))
                    {
                        myConn.Open();

                        using (SqlCommand myCommand = new SqlCommand(mySql, myConn))
                        {
                            myCommand.Parameters.AddWithValue("@i", ID);
                            myCommand.ExecuteNonQuery();
                        }

                        myConn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Close();
            }
            else
            {
                VariablesAndFunctions.commandType = string.Empty;
            }
        }
    }
}
