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
    public partial class UpdateTeacher : UserControl
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
        private static UpdateTeacher _Instance;

        public static UpdateTeacher instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UpdateTeacher();
                return _Instance;
            }
        }
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTeacherId.Text.Trim() == string.Empty || txtTeachername.Text.Trim() == string.Empty || txtTeacherPassword.Text.Trim() == string.Empty || txtTeachersEmail.Text.Trim() == string.Empty || txtDepartmentId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {


                string str;
                DataTable dt;
                int RowCount;
                OracleDataAdapter orada;

                str = "UPDATE teacher SET teacher_name='" + txtTeachername.Text + "',password='" + txtTeacherPassword.Text + "',email='" + txtTeachersEmail.Text + "',date_of_birth='" + txtDob.Text + "',gender='" + txtGender.Text + "',blood_group='" + txtBloodG.Text + "',hiredate='" + txtBloodG.Text + "',salary='" + txtSalary.Text + "',address='" + txtAddress.Text + "',phone_number='" + txtPhone.Text + "',designation='" + txtDesignation.Text + "',department_id='" + Convert.ToInt32(txtDepartmentId.Text) + "' WHERE teacher_id=" + Convert.ToInt32(txtTeacherId.Text);

                OracleCommand com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;
                if (RowCount > 0)
                {
                    MessageBox.Show("Teacher Info updated");


                }
                else
                {
                    MessageBox.Show("teacher Info updated");
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



            str = "Select * from Teacher";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridViewTeachers.DataSource = dt;
                dataGridViewTeachers.Refresh();
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count == 1)
            {
                txtTeacherId.Text = dataGridViewTeachers.CurrentRow.Cells["teacher_id"].Value.ToString();
                txtTeachername.Text = dataGridViewTeachers.CurrentRow.Cells["teacher_name"].Value.ToString();
                txtTeacherPassword.Text = dataGridViewTeachers.CurrentRow.Cells["password"].Value.ToString();
                txtTeachersEmail.Text = dataGridViewTeachers.CurrentRow.Cells["email"].Value.ToString();
                txtDob.Text = dataGridViewTeachers.CurrentRow.Cells["date_of_birth"].Value.ToString();
                txtGender.Text = dataGridViewTeachers.CurrentRow.Cells["gender"].Value.ToString();
                txtBloodG.Text = dataGridViewTeachers.CurrentRow.Cells["blood_group"].Value.ToString();
                txtHiredate.Text = dataGridViewTeachers.CurrentRow.Cells["hiredate"].Value.ToString();
                txtSalary.Text = dataGridViewTeachers.CurrentRow.Cells["salary"].Value.ToString();
                txtAddress.Text = dataGridViewTeachers.CurrentRow.Cells["address"].Value.ToString();
                txtPhone.Text = dataGridViewTeachers.CurrentRow.Cells["phone_number"].Value.ToString();
                txtDesignation.Text = dataGridViewTeachers.CurrentRow.Cells["designation"].Value.ToString();
                txtDepartmentId.Text = dataGridViewTeachers.CurrentRow.Cells["department_id"].Value.ToString();

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

        private void txtDepartmentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
