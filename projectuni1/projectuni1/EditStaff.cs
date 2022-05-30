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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdatestuff_Click(object sender, EventArgs e)
        {
            if (!panelStuff.Controls.Contains(UpdateStuff.instance))
            {
                panelStuff.Controls.Add(UpdateStuff.instance);
                UpdateStuff.instance.Dock = DockStyle.Fill;
                UpdateStuff.instance.BringToFront();

            }
            else
                UpdateStuff.instance.BringToFront();
        }

        private void btnAddstuff_Click(object sender, EventArgs e)
        {
            if (!panelStuff.Controls.Contains(AddStuffs.instance))
            {
                panelStuff.Controls.Add(AddStuffs.instance);
                AddStuffs.instance.Dock = DockStyle.Fill;
                AddStuffs.instance.BringToFront();

            }
            else
                AddStuffs.instance.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.ShowDialog();
        }

        private void btnDeletestuff_Click(object sender, EventArgs e)
        {
            if (!panelStuff.Controls.Contains(DeleteStuff.instance))
            {
                panelStuff.Controls.Add(DeleteStuff.instance);
                DeleteStuff.instance.Dock = DockStyle.Fill;
                DeleteStuff.instance.BringToFront();

            }
            else
                DeleteStuff.instance.BringToFront();
        }

        private void EditStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
