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
    public partial class AssignCourse : UserControl
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


        private static AssignCourse _Instance;

        public static AssignCourse instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AssignCourse();
                return _Instance;
            }
        }
        public AssignCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            if (txtboxCourseId.Text.Trim() == string.Empty || txtboxStudentId.Text.Trim() == string.Empty || txtboxTeachersId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {

                string sql_Student_Course_Insert = "Insert into Student_course (student_id,teacher_id,course_id) values (" + Convert.ToInt32(txtboxStudentId.Text) + "," + Convert.ToInt32(txtboxTeachersId.Text) + "," + Convert.ToInt32(txtboxCourseId.Text) + ")";

                OracleCommand sqcom = new OracleCommand(sql_Student_Course_Insert, Sqlconn);



                int count = sqcom.ExecuteNonQuery();


                if (count >= 1)
                {
                    MessageBox.Show("Student Assigned");
                    txtboxCourseId.Clear();
                    txtboxStudentId.Clear();
                    txtboxTeachersId.Clear();


                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
        }

        private void txtboxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxTeachersId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxCourseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
