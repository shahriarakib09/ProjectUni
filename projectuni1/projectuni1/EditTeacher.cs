using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectuni1
{
    public partial class EditTeacher : Form
    {
        public EditTeacher()
        {
            InitializeComponent();
        }

        private void btnAddteacher_Click(object sender, EventArgs e)
        {
            if (!panelTeacher.Controls.Contains(AddTeacher.instance))
            {
                panelTeacher.Controls.Add(AddTeacher.instance);
                AddTeacher.instance.Dock = DockStyle.Fill;
                AddTeacher.instance.BringToFront();

            }
            else
                AddTeacher.instance.BringToFront();
        }

        private void btnUpdateteacher_Click(object sender, EventArgs e)
        {
            if (!panelTeacher.Controls.Contains(UpdateTeacher.instance))
            {
                panelTeacher.Controls.Add(UpdateTeacher.instance);
                UpdateTeacher.instance.Dock = DockStyle.Fill;
                UpdateTeacher.instance.BringToFront();

            }
            else
                UpdateTeacher.instance.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.ShowDialog();
        }

        private void btnDeleteteacher_Click(object sender, EventArgs e)
        {
            if (!panelTeacher.Controls.Contains(DeleteTeacher.instance))
            {
                panelTeacher.Controls.Add(DeleteTeacher.instance);
                DeleteTeacher.instance.Dock = DockStyle.Fill;
                DeleteTeacher.instance.BringToFront();

            }
            else
                DeleteTeacher.instance.BringToFront();
        }

        private void EditTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
