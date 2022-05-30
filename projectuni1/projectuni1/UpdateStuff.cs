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
    public partial class UpdateStuff : UserControl
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
        private static UpdateStuff _Instance;

        public static UpdateStuff instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UpdateStuff();
                return _Instance;
            }
        }
        public UpdateStuff()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtStuffId.Text.Trim() == string.Empty || txtStuffname.Text.Trim() == string.Empty || txtStuffPassword.Text.Trim() == string.Empty || txtStuffEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill up the textbox field!");

            }
            else
            {


                string str;
                DataTable dt;
                int RowCount;
                OracleDataAdapter orada;

                str = "UPDATE Stuff SET stuff_name='" + txtStuffname.Text + "',password='" + txtStuffPassword.Text + "',email='" + txtStuffEmail.Text + "',gender='" + txtGender.Text + "',blood_group='" + txtBloodG.Text + "',hiredate='" + txtHiredate.Text + "',salary='" + txtSalary.Text + "',address='" + txtAddress.Text + "',phone_number='" + txtPhone.Text + "',date_of_birth='" + txtDob.Text + "' WHERE stuff_id=" + Convert.ToInt32(txtStuffId.Text);

                OracleCommand com = new OracleCommand(str, Sqlconn);

                orada = new OracleDataAdapter(com);

                dt = new DataTable();

                orada.Fill(dt);

                RowCount = dt.Rows.Count;
                if (RowCount > 0)
                {
                    MessageBox.Show("Stuff Info updated");


                }
                else
                {
                    MessageBox.Show("Stuff Info updated");
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



            str = "Select * from Stuff";

            com = new OracleCommand(str, Sqlconn);

            orada = new OracleDataAdapter(com);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;

            if (RowCount > 1)

            {
                dataGridViewStuff.DataSource = dt;
                dataGridViewStuff.Refresh();
            }
        }

        private void cmsModifyStuff_Click(object sender, EventArgs e)
        {

            if (dataGridViewStuff.SelectedRows.Count == 1)
            {
                txtStuffId.Text = dataGridViewStuff.CurrentRow.Cells["stuff_id"].Value.ToString();
                txtStuffname.Text = dataGridViewStuff.CurrentRow.Cells["stuff_name"].Value.ToString();
                txtStuffPassword.Text = dataGridViewStuff.CurrentRow.Cells["password"].Value.ToString();
                txtStuffEmail.Text = dataGridViewStuff.CurrentRow.Cells["email"].Value.ToString();
                txtDob.Text = dataGridViewStuff.CurrentRow.Cells["date_of_birth"].Value.ToString();
                txtGender.Text = dataGridViewStuff.CurrentRow.Cells["gender"].Value.ToString();
                txtBloodG.Text = dataGridViewStuff.CurrentRow.Cells["blood_group"].Value.ToString();
                txtHiredate.Text = dataGridViewStuff.CurrentRow.Cells["hiredate"].Value.ToString();
                txtSalary.Text = dataGridViewStuff.CurrentRow.Cells["salary"].Value.ToString();
                txtAddress.Text = dataGridViewStuff.CurrentRow.Cells["address"].Value.ToString();
                txtPhone.Text = dataGridViewStuff.CurrentRow.Cells["phone_number"].Value.ToString();

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

        private void txtStuffId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
