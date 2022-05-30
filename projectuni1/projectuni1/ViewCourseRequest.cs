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
    public partial class ViewCourseRequest : UserControl
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
        private static ViewCourseRequest _Instance;

        public static ViewCourseRequest instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ViewCourseRequest();
                return _Instance;
            }
        }
        public ViewCourseRequest()
        {
            InitializeComponent();
        }

        private void btnViewCourseRequest_Click(object sender, EventArgs e)
        {
            string str;
            DataTable dt;
            int RowCount;
            OracleDataAdapter orada;

            //int UserId = txtUserId.Text;

            //string Password = txtPassword.Text;



            str = "Select * from course_request";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();


            }
        }
    }
}
