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
    public partial class AdminDelete : Form
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
        public AdminDelete()
        {
            InitializeComponent();
        }

        private void adminInfoButton_Click(object sender, EventArgs e)
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
                dataGridViewAllAdmin.DataSource = dt;
                dataGridViewAllAdmin.Refresh();


            }
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            if (txtAdminDeleteId.Text.Trim() == string.Empty)
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



                str = "Delete from admin where admin_id='" + Convert.ToInt32(txtAdminDeleteId.Text) + "'";

                com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;

                if (RowCount > 1)

                {
                    MessageBox.Show("Admin Deleted");
                    dataGridViewAllAdmin.Refresh();



                }

                else

                {
                    MessageBox.Show("Admin Deleted");
                    dataGridViewAllAdmin.Refresh();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.ShowDialog();
        }

        private void txtAdminDeleteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminUserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminDelete_Load(object sender, EventArgs e)
        {

        }

        private void txtAdminDeleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

