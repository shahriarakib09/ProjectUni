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
    public partial class StudentMarks : UserControl
    {
        private static StudentMarks _Instance;

        public static StudentMarks instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new StudentMarks();
                return _Instance;
            }
        }
        public StudentMarks()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTUNI;Password=tiger"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = "student_marks";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("sid", OracleDbType.Int32).Value = Int32.Parse(textBoxStudentId.Text);
                    Cmd.Parameters.Add("courseid", OracleDbType.Int32).Value = Int32.Parse(txtboxCourseId.Text);
                    Cmd.Parameters.Add("marks", OracleDbType.Int32).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();

                    var result = Cmd.Parameters["marks"].Value.ToString();
                    txtboxGrade.Text = result.ToString();

                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oCon.Close();
                }

            }
        }

        private void textBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxCourseId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
