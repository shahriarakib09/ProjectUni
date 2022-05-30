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
using projectuni1.DataAccessLayer;


namespace projectuni1
{
    public partial class Registration : Form
    {
        private OracleCommand com;
        private OracleCommand com1;

        private static OracleConnection Sqlcon;
        
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
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAdminId.Text.Trim() == string.Empty || txtAdminname.Text.Trim() == string.Empty || txtAdminPassword.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty || txtAddress.Text.Trim() == string.Empty || txtBloodG.Text.Trim() == string.Empty || txtGender.Text.Trim() == string.Empty || txtDob.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {

           

                //DataTable dt;
                //int RowCount;
                //OracleDataAdapter orada;





                string sql_Admin_Insert = "Insert into Admin (admin_id,admin_name,password,email,gender,blood_group,address,phone_number,date_of_birth) values (" + Convert.ToInt32(txtAdminId.Text) + ",'" + txtAdminname.Text.ToString() + "','" + txtAdminPassword.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtGender.Text.ToString() + "','" + txtBloodG.Text.ToString() + "','" + txtAddress.Text.ToString() + "'," + Convert.ToInt32(txtPhone.Text) + ",'" + txtDob.Text.ToString()+ "')";
                string sql_user_Insert = "Insert into Login (user_id,password) values (" + Convert.ToInt32(txtAdminId.Text) + ",'" + txtAdminPassword.Text.ToString() + "')";

                OracleCommand sqcom = new OracleCommand(sql_Admin_Insert, Sqlconn);
                OracleCommand sqcom1 = new OracleCommand(sql_user_Insert, Sqlconn);


               int count = sqcom.ExecuteNonQuery();
                int count1 = sqcom1.ExecuteNonQuery();

                if (count>=1 &&count1>=1)
                {
                    MessageBox.Show("Success");
                    txtAdminId.Clear();
                    txtAdminname.Clear();
                    txtAdminPassword.Clear();
                    txtEmail.Clear();
                    txtGender.Clear();
                    txtBloodG.Clear();
                    txtAddress.Clear();
                    txtPhone.Clear();
                    txtDob.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                      

              

                //dt = new DataTable();

                //orada.Fill(dt);

                //RowCount = dt.Rows.Count;

                //if (RowCount == 1)

                //{


                //    MessageBox.Show("Admin Registration Successful");

                //}

                //else

                //{

                //    MessageBox.Show("Invalid! Please try again!");
                //}

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdminId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
