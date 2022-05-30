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
    public partial class AddTeacher : UserControl
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
        private static AddTeacher _Instance;

        public static AddTeacher instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddTeacher();
                return _Instance;
            }
        }
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTeacherId.Text.Trim() == string.Empty || txtTeachername.Text.Trim() == string.Empty || txtAdminPassword.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {
                string sql_Teacher_Insert = "Insert into teacher (teacher_id,teacher_name,password,email,date_of_birth,gender,blood_group,hiredate,salary,address,phone_number,designation,department_id) values (" + Convert.ToInt32(txtTeacherId.Text) + ",'" + txtTeachername.Text.ToString() + "','" + txtAdminPassword.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtDob.Text.ToString() + "','" + txtGender.Text.ToString() + "','" + txtBloodG.Text.ToString() + "','" + txtHiredate.Text.ToString() + "','" + txtSalary.Text.ToString() + "','" + txtAddress.Text.ToString() + "','" + txtPhone.Text.ToString() + "','" + txtDesignation.Text.ToString() + "','" + Convert.ToInt32(txtDepartmentId.Text) + "')";
                string sql_user_Insert = "Insert into Login (user_id,password) values (" + Convert.ToInt32(txtTeacherId.Text) + ",'" + txtAdminPassword.Text.ToString() + "')";

                OracleCommand sqcom = new OracleCommand(sql_Teacher_Insert, Sqlconn);
                OracleCommand sqcom1 = new OracleCommand(sql_user_Insert, Sqlconn);


                int count = sqcom.ExecuteNonQuery();
                int count1 = sqcom1.ExecuteNonQuery();

                if (count >= 1 && count1 >= 1)
                {
                    MessageBox.Show("Teacher Added");
                    txtTeacherId.Clear();
                    txtTeachername.Clear();
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

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
