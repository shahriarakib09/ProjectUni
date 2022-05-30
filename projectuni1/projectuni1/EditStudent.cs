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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnAddstudent_Click(object sender, EventArgs e)
        {
            if (!panelStudent.Controls.Contains(AddStudent.instance))
            {
                panelStudent.Controls.Add(AddStudent.instance);
                AddStudent.instance.Dock = DockStyle.Fill;
                AddStudent.instance.BringToFront();

            }
            else
                AddStudent.instance.BringToFront();
        }

        private void btnUpdatestudent_Click(object sender, EventArgs e)
        {
            if (!panelStudent.Controls.Contains(UpdateStudent.instance))
            {
                panelStudent.Controls.Add(UpdateStudent.instance);
                UpdateStudent.instance.Dock = DockStyle.Fill;
                UpdateStudent.instance.BringToFront();

            }
            else
                UpdateStudent.instance.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            this.Hide();
            adminPage.ShowDialog();
        }

        private void btnDeletestudent_Click(object sender, EventArgs e)
        {
            if (!panelStudent.Controls.Contains(DeleteStudent.instance))
            {
                panelStudent.Controls.Add(DeleteStudent.instance);
                DeleteStudent.instance.Dock = DockStyle.Fill;
                DeleteStudent.instance.BringToFront();

            }
            else
                DeleteStudent.instance.BringToFront();
        }

        private void EditStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
