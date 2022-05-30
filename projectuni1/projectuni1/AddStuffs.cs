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
    public partial class AddStuffs : UserControl
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
        private static AddStuffs _Instance;

        public static AddStuffs instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddStuffs();
                return _Instance;
            }
        }
        public AddStuffs()
        {
            InitializeComponent();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtStuffId.Text.Trim() == string.Empty || txtStuffname.Text.Trim() == string.Empty || txtAdminPassword.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {



                //DataTable dt;
                //int RowCount;
                //OracleDataAdapter orada;





                string sql_Stuff_Insert = "Insert into Stuff (stuff_id,stuff_name,password,email,date_of_birth,gender,blood_group,hiredate,salary,address,phone_number) values (" + Convert.ToInt32(txtStuffId.Text) + ",'" + txtStuffname.Text.ToString() + "','" + txtAdminPassword.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtDob.Text.ToString() + "','" + txtGender.Text.ToString() + "','" + txtBloodG.Text.ToString() + "','" + txtHiredate.Text.ToString() + "','" + txtSalary.Text.ToString() + "','" + txtAddress.Text.ToString() + "','" + txtPhone.Text.ToString() + "')";
                string sql_user_Insert = "Insert into Login (user_id,password) values (" + Convert.ToInt32(txtStuffId.Text) + ",'" + txtAdminPassword.Text.ToString() + "')";

                OracleCommand sqcom = new OracleCommand(sql_Stuff_Insert, Sqlconn);
                OracleCommand sqcom1 = new OracleCommand(sql_user_Insert, Sqlconn);


                int count = sqcom.ExecuteNonQuery();
                int count1 = sqcom1.ExecuteNonQuery();

                if (count >= 1 && count1 >= 1)
                {
                    MessageBox.Show("Success");
                    txtStuffId.Clear();
                    txtStuffname.Clear();
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
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStuffId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}