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
    public partial class UploadGrade : UserControl
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
        private static UploadGrade _Instance;

        public static UploadGrade instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UploadGrade();
                return _Instance;
            }
        }
        public UploadGrade()
        {
            InitializeComponent();
        }

        private void UploadGrade_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentId.Text.Trim() == string.Empty || txtBoxCourseId.Text.Trim() == string.Empty || Int32.Parse(txtBoxGrade.Text)>100)
            {
                MessageBox.Show("Please enter a valid value!");

            }
            else
            {

                string str;
                DataTable dt;
                int RowCount;
                OracleDataAdapter orada;

                //int UserId = txtUserId.Text;

                //string Password = txtPassword.Text;



                str = "Update student_course set marks=" + Convert.ToInt32(txtBoxGrade.Text) + " WHERE student_id='" + Convert.ToInt32(txtBoxStudentId.Text) + "' AND course_id='" + Convert.ToInt32(txtBoxCourseId.Text) + "'";

                com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;

                if (RowCount > 0)

                {
                    MessageBox.Show("Student Deleted");
                    txtBoxStudentId.Clear();
                    txtBoxCourseId.Clear();
                    txtBoxGrade.Clear();




                }

                else

                {
                    MessageBox.Show("Grade Uploaded");
                    txtBoxStudentId.Clear();
                    txtBoxCourseId.Clear();
                    txtBoxGrade.Clear();


                }
            }

        }
    }
}
