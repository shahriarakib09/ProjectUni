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
    public partial class StudentCourseRequest : UserControl
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
        private static StudentCourseRequest _Instance;

        public static StudentCourseRequest instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new StudentCourseRequest();
                return _Instance;
            }
        }
        public StudentCourseRequest()
        {
            InitializeComponent();
        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (txtboxStudentId.Text.Trim() == string.Empty || txtboxCourseId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {

                string sql_Course_request_Insert = "Insert into Course_request (Student_id,Course_id) values (" + Convert.ToInt32(txtboxStudentId.Text) + "," + Convert.ToInt32(txtboxCourseId.Text) + ")";

                OracleCommand sqcom = new OracleCommand(sql_Course_request_Insert, Sqlconn);



                int count = sqcom.ExecuteNonQuery();


                if (count >= 1)
                {
                    MessageBox.Show("Course Requested");
                    txtboxStudentId.Clear();
                    txtboxCourseId.Clear();



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

        private void txtboxCourseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
