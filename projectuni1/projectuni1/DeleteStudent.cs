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
    public partial class DeleteStudent : UserControl
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
        private static DeleteStudent _Instance;

        public static DeleteStudent instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DeleteStudent();
                return _Instance;
            }
        }
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (txtStudentDeleteId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {

                string str;
                DataTable dt;
                int RowCount;
                OracleDataAdapter orada;

                //int UserId = txtUserId.Text;

                //string Password = txtPassword.Text;



                str = "Delete from student where student_id='" + Convert.ToInt32(txtStudentDeleteId.Text) + "'";

                com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;

                if (RowCount > 0)

                {
                    MessageBox.Show("Student Deleted");
                    txtStudentDeleteId.Clear();




                }

                else

                {
                    MessageBox.Show("Student not Deleted");
                    

                }
            }
        }

        private void txtStudentDeleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
