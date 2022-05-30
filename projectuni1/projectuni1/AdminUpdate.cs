using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projectuni1
{
    public partial class AdminUpdate : Form
    {
        private OracleCommand com;
        private static OracleConnection Sqlcon;
        //string strConnString = ConfigurationManager.ConnectionStrings["PROJECTUNI"].ConnectionString;
        public static OracleConnection Sqlconn
        {
            get
            {
                if (Sqlcon == null)
                {
                    Sqlcon = new OracleConnection(@"TNS_ADMIN=F:\app\oracle\product\10.2.0\server\NETWORK\ADMIN;USER ID=PROJECTUNI; Password=tiger; DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True");
                }
                else if (Sqlcon.State != ConnectionState.Open)
                {
                    Sqlcon.Open();
                }
                return Sqlcon;
            }
        }
        public AdminUpdate()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAdminId.Text != string.Empty || txtAdminname.Text != string.Empty || txtEmail.Text != string.Empty)
            {



                if (!txtEmail.Text.Contains(".") && !txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Invalid Email");

                }


                else
                {


                    string str;
                    DataTable dt;
                    int RowCount;
                    OracleDataAdapter orada;

                    str = "UPDATE Admin SET admin_name='" + txtAdminname.Text + "',password='" + txtAdminPassword.Text + "',email='" + txtEmail.Text + "',gender='" + txtGender.Text + "',blood_group='" + txtBloodG.Text + "',hiredate='" + dateTimePickerHiredate.Value.ToString("dd-MMM-yyyy") + "',salary='" + txtSalary.Text + "',address='" + txtAddress.Text + "',phone_number='" + txtPhone.Text + "',date_of_birth='" + txtDob.Text + "' WHERE admin_id=" + Convert.ToInt32(txtAdminId.Text);

                    OracleCommand com = new OracleCommand(str, Sqlconn);

                    orada = new OracleDataAdapter(com);

                    dt = new DataTable();

                    orada.Fill(dt);

                    RowCount = dt.Rows.Count;
                    if (RowCount > 0)
                    {
                        MessageBox.Show("Admin Info updated");


                    }
                    else
                    {
                        MessageBox.Show("Admin Info updated");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str;
            DataTable dt;
            int RowCount;
            OracleDataAdapter orada;

            //int UserId = txtUserId.Text;

            //string Password = txtPassword.Text;



            str = "Select * from Admin";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridViewAdmin.DataSource = dt;
                dataGridViewAdmin.Refresh();


            }
        }

        private void cmsModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 1)
            {
                txtAdminId.Text = dataGridViewAdmin.CurrentRow.Cells["admin_id"].Value.ToString();
                txtAdminname.Text = dataGridViewAdmin.CurrentRow.Cells["admin_name"].Value.ToString();
                txtAdminPassword.Text = dataGridViewAdmin.CurrentRow.Cells["password"].Value.ToString();
                txtEmail.Text = dataGridViewAdmin.CurrentRow.Cells["email"].Value.ToString();
                txtDob.Text = dataGridViewAdmin.CurrentRow.Cells["date_of_birth"].Value.ToString();
                txtGender.Text = dataGridViewAdmin.CurrentRow.Cells["gender"].Value.ToString();
                txtBloodG.Text = dataGridViewAdmin.CurrentRow.Cells["blood_group"].Value.ToString();
                dateTimePickerHiredate.Text = dataGridViewAdmin.CurrentRow.Cells["hiredate"].Value.ToString();
                txtSalary.Text = dataGridViewAdmin.CurrentRow.Cells["salary"].Value.ToString();
                txtAddress.Text = dataGridViewAdmin.CurrentRow.Cells["address"].Value.ToString();
                txtPhone.Text = dataGridViewAdmin.CurrentRow.Cells["phone_number"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Select a row first");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdminId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AdminUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}







