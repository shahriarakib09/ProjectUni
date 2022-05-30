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
    public partial class StuffPanel : Form
    {
        public StuffPanel()
        {
            InitializeComponent();
        }

        private void btnViewRequest_Click(object sender, EventArgs e)
        {
            if (!panelStuffHomePage.Controls.Contains(ViewCourseRequest.instance))
            {
                panelStuffHomePage.Controls.Add(ViewCourseRequest.instance);
                ViewCourseRequest.instance.Dock = DockStyle.Fill;
                ViewCourseRequest.instance.BringToFront();

            }
            else
                ViewCourseRequest.instance.BringToFront();
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {

            if (!panelStuffHomePage.Controls.Contains(AssignCourse.instance))
            {
                panelStuffHomePage.Controls.Add(AssignCourse.instance);
                AssignCourse.instance.Dock = DockStyle.Fill;
                AssignCourse.instance.BringToFront();

            }
            else
                AssignCourse.instance.BringToFront();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void StuffPanel_Load(object sender, EventArgs e)
        {
            if (!panelStuffHomePage.Controls.Contains(StuffPage.instance))
            {
                panelStuffHomePage.Controls.Add(StuffPage.instance);
                StuffPage.instance.Dock = DockStyle.Fill;
                StuffPage.instance.BringToFront();

            }
            else
                StuffPage.instance.BringToFront();

        }

        private void StuffPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
