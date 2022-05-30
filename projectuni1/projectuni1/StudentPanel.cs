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
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
        }

        private void btnViewGrade_Click(object sender, EventArgs e)
        {
            if (!panelStudentHomepage.Controls.Contains(StudentMarks.instance))
            {
                panelStudentHomepage.Controls.Add(StudentMarks.instance);
                StudentMarks.instance.Dock = DockStyle.Fill;
                StudentMarks.instance.BringToFront();

            }
            else
                StudentMarks.instance.BringToFront();
        }

        private void btnRequestCourse_Click(object sender, EventArgs e)
        {
            if (!panelStudentHomepage.Controls.Contains(StudentCourseRequest.instance))
            {
                panelStudentHomepage.Controls.Add(StudentCourseRequest.instance);
                StudentCourseRequest.instance.Dock = DockStyle.Fill;
                StudentCourseRequest.instance.BringToFront();

            }
            else
                StudentCourseRequest.instance.BringToFront();
        }

        private void btnStudyMetarial_Click(object sender, EventArgs e)
        {
            if (!panelStudentHomepage.Controls.Contains(files.instance))
            {
                panelStudentHomepage.Controls.Add(files.instance);
                files.instance.Dock = DockStyle.Fill;
                files.instance.BringToFront();

            }
            else
                files.instance.BringToFront();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            if (!panelStudentHomepage.Controls.Contains(StudentPage.instance))
            {
                panelStudentHomepage.Controls.Add(StudentPage.instance);
                StudentPage.instance.Dock = DockStyle.Fill;
                StudentPage.instance.BringToFront();

            }
            else
                StudentPage.instance.BringToFront();
        }

        private void StudentPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

