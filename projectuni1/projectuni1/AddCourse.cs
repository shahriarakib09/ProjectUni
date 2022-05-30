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
    public partial class AddCourse : Form
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
        public AddCourse()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.ShowDialog();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            string str;
            DataTable dt;
            int RowCount;
            OracleDataAdapter orada;

            //int UserId = txtUserId.Text;

            //string Password = txtPassword.Text;



            str = "Select * from Course";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourseId.Text.Trim() == string.Empty || txtCourseName.Text.Trim() == string.Empty || txtDeptId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {

                string sql_Course_Insert = "Insert into Course (Course_id,course_name,department_id) values (" + Convert.ToInt32(txtCourseId.Text) + ",'" + txtCourseName.Text.ToString() + "'," + Convert.ToInt32(txtDeptId.Text) + ")";

                OracleCommand sqcom = new OracleCommand(sql_Course_Insert, Sqlconn);



                int count = sqcom.ExecuteNonQuery();


                if (count >= 1)
                {
                    MessageBox.Show("New Course Added");
                    txtCourseId.Clear();
                    txtCourseName.Clear();
                    txtDeptId.Clear();
                    dataGridViewAllAdmin.Refresh();


                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
        }

        private void AddCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

