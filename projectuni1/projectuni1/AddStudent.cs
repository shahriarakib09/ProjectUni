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
    public partial class AddStudent : UserControl
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
        private static AddStudent _Instance;

        public static AddStudent instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddStudent();
                return _Instance;
            }
        }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text.Trim() == string.Empty || txtStudentname.Text.Trim() == string.Empty || txtAdminPassword.Text.Trim() == string.Empty || txtEmail.Text.Trim() == string.Empty || txtDepartmentId.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {
                string sql_Student_Insert = "Insert into Student (student_id,student_name,password,email,date_of_birth,gender,blood_group,address,phone_number,gurdian_contact,admission_year,department_id) values (" + Convert.ToInt32(txtStudentId.Text.ToString()) + ",'" + txtStudentname.Text.ToString() + "','" + txtAdminPassword.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtDob.Text.ToString() + "','" + txtGender.Text.ToString() + "','" + txtBloodG.Text.ToString() + "','" + txtAddress.Text.ToString() + "','" + txtPhone.Text.ToString() + "','" + txtGC.Text.ToString() + "','" + txtAdmissionYear.Text.ToString() + "'," + Convert.ToInt32(txtDepartmentId.Text.ToString()) + ")";
                string sql_user_Insert = "Insert into Login (user_id,password) values (" + Convert.ToInt32(txtStudentId.Text) + ",'" + txtAdminPassword.Text.ToString() + "')";

                OracleCommand sqcom = new OracleCommand(sql_Student_Insert, Sqlconn);
                OracleCommand sqcom1 = new OracleCommand(sql_user_Insert, Sqlconn);


                int count = sqcom.ExecuteNonQuery();
                int count1 = sqcom1.ExecuteNonQuery();

                if (count >= 1 && count1 >= 1)
                {
                    MessageBox.Show("Student Added");
                    txtStudentId.Clear();
                    txtStudentname.Clear();
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

        private void txtGC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
