using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectuni1
{
    public partial class AdminPage : Form
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
        public AdminPage()
        {
            InitializeComponent();
        }

        private void adminInfoButton_Click(object sender, EventArgs e)
        {
            string str;
            DataTable dt;
            int RowCount;
            OracleDataAdapter orada;

            //int UserId = txtUserId.Text;

            //string Password = txtPassword.Text;



            str = "Select * from Admin";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridViewAdminInfo.DataSource = dt;
                dataGridViewAdminInfo.Refresh();


            }
        }

        private void viewStuffButton_Click(object sender, EventArgs e)
        {
            string str;
            DataTable dt;
            int RowCount;
            OracleDataAdapter orada;

            //int UserId = txtUserId.Text;

            //string Password = txtPassword.Text;



            str = "Select * from Stuff";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridViewSTSList.DataSource = dt;
                dataGridViewSTSList.Refresh();
            }
        }

        private void viewTeacherButton_Click(object sender, EventArgs e)
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
                dataGridViewSTSList.DataSource = dt;
                dataGridViewSTSList.Refresh();
            }
        }

        private void viewStudentButton_Click(object sender, EventArgs e)
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
                dataGridViewSTSList.DataSource = dt;
                dataGridViewSTSList.Refresh();
            }
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            AdminDelete adminDelete = new AdminDelete();
            this.Hide();
            adminDelete.ShowDialog();

        }

        private void updateAdminButton_Click(object sender, EventArgs e)
        {
            AdminUpdate adminUpdate = new AdminUpdate();
            this.Hide();
            adminUpdate.ShowDialog();
        }

        private void EdtstaffButton_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff();
            this.Hide();
            editStaff.ShowDialog();
        }

        private void edtteacherButton_Click(object sender, EventArgs e)
        {
            EditTeacher editTeacher = new EditTeacher();
            this.Hide();
            editTeacher.ShowDialog();
        }

        private void edtstudentButton_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            this.Hide();
            editStudent.ShowDialog();
        }

        private void btnGoToTeacher_Click(object sender, EventArgs e)
        {
            TeachersPanel teachersPanel = new TeachersPanel();
            this.Hide();
            teachersPanel.ShowDialog();

        }

        private void btnGoToStudent_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel();
            this.Hide();
            studentPanel.ShowDialog();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            this.Hide();
            addCourse.ShowDialog();
        }

        private void btnStuff_Click(object sender, EventArgs e)
        {
            StuffPanel stuffPanel = new StuffPanel();
            this.Hide();
            stuffPanel.ShowDialog();
        }

        private void dataGridViewAdminInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
