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
    public partial class UpdateStudent : UserControl
    {
        private OracleCommand com;
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
        private static UpdateStudent _Instance;

        public static UpdateStudent instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UpdateStudent();
                return _Instance;
            }
        }
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text.Trim() == string.Empty || txtStudentname.Text.Trim() == string.Empty || txtStudentPassword.Text.Trim() == string.Empty || txtStudentEmail.Text.Trim() == string.Empty || txtDepartmentId.Text.Trim() == string.Empty ) 
         
           
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {


                string str;
                DataTable dt;
                int RowCount;
                OracleDataAdapter orada;

                str = "UPDATE Student SET student_name='" + txtStudentname.Text + "',password='" + txtStudentPassword.Text + "',email='" + txtStudentEmail.Text + "',date_of_birth='" + txtDob.Text + "',gender='" + txtGender.Text + "',blood_group='" + txtBloodG.Text + "',phone_number='" + txtPhone.Text + "',gurdian_contact='" + txtGC.Text + "',admission_year='" + txtAdmissionYear.Text.ToString() + "',department_id='" + Convert.ToInt32(txtDepartmentId.Text) + "' WHERE student_id=" + Convert.ToInt32(txtStudentId.Text);

                OracleCommand com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;
                if (RowCount > 0)
                {
                    MessageBox.Show("Student Info updated");


                }
                else
                {
                    MessageBox.Show("Student Info updated");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            DataTable dt;
            int RowCount;
            OracleDataAdapter orada;

            //int UserId = txtUserId.Text;

            //string Password = txtPassword.Text;



            str = "Select * from Student";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridViewStudent.DataSource = dt;
                dataGridViewStudent.Refresh();
            }
        }

        private void contextMenuStripStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 1)
            {
                txtStudentId.Text = dataGridViewStudent.CurrentRow.Cells["student_id"].Value.ToString();
                txtStudentname.Text = dataGridViewStudent.CurrentRow.Cells["student_name"].Value.ToString();
                txtStudentPassword.Text = dataGridViewStudent.CurrentRow.Cells["password"].Value.ToString();
                txtStudentEmail.Text = dataGridViewStudent.CurrentRow.Cells["email"].Value.ToString();
                txtDob.Text = dataGridViewStudent.CurrentRow.Cells["date_of_birth"].Value.ToString();
                txtGender.Text = dataGridViewStudent.CurrentRow.Cells["gender"].Value.ToString();
                txtBloodG.Text = dataGridViewStudent.CurrentRow.Cells["blood_group"].Value.ToString();
                txtPhone.Text = dataGridViewStudent.CurrentRow.Cells["phone_number"].Value.ToString();
                txtGC.Text = dataGridViewStudent.CurrentRow.Cells["gurdian_contact"].Value.ToString();
                txtAddress.Text = dataGridViewStudent.CurrentRow.Cells["address"].Value.ToString();
                txtAdmissionYear.Text = dataGridViewStudent.CurrentRow.Cells["admission_year"].Value.ToString();
                txtDepartmentId.Text = dataGridViewStudent.CurrentRow.Cells["department_id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Select a row first");
            }
        }

        private void txtDepartmentId_TextChanged(object sender, EventArgs e)
        {

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

        private void txtAdmissionYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDepartmentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
