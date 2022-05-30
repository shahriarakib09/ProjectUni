using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace projectuni1
{
    public partial class Login : Form
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




        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminId.Text.Trim() == string.Empty && txtPassword.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {

                string str;
                DataTable dt;
                int RowCount;
                OracleDataAdapter orada;

                //int UserId = txtUserId.Text;

                //string Password = txtPassword.Text;



                str = "Select * from Admin where Admin_id='" + Convert.ToInt32(txtAdminId.Text) + "' and password='" + txtPassword.Text.ToString() + "'";

                com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;

                if (RowCount == 1)

                {

                   
                    MessageBox.Show("Login Successful");
                    AdminPage adminPage = new AdminPage();
                    this.Hide();
                    adminPage.ShowDialog();

                }

                else

                {

                    MessageBox.Show("Invalid User id or Password! Please try again!");
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
            
        }

        private void loginAsAdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void loginAsStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginStuff loginStuff = new LoginStuff();
            this.Hide();
            loginStuff.ShowDialog();
        }

        private void loginAsTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginTeacher loginTeacher = new LoginTeacher();
            this.Hide();
            loginTeacher.ShowDialog();
        }

        private void loginAsStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginStudent loginStudent = new LoginStudent();
            this.Hide();
            loginStudent.ShowDialog();
        }

        private void txtAdminId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}



