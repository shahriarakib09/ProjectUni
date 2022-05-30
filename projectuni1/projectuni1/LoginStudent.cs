using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace projectuni1
{
    public partial class LoginStudent : Form
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
        public LoginStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text.Trim() == string.Empty && txtPassword.Text.Trim() == string.Empty)
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



                str = "Select * from Student where student_id='" + Convert.ToInt32(txtStudentId.Text) + "' and password='" + txtPassword.Text.ToString() + "'";

                com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;

                if (RowCount == 1)

                {


                    MessageBox.Show("Login Successful");
                    StudentPanel studentPanel = new StudentPanel();
                    this.Hide();
                    studentPanel.ShowDialog();

                }

                else

                {

                    MessageBox.Show("Invalid User id or Password! Please try again!");
                }
            }
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void LoginStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
