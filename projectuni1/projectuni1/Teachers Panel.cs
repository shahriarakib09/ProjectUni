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
    public partial class TeachersPanel : Form
    {
        public TeachersPanel()
        {
            InitializeComponent();
        }

        private void Teachers_Panel_Load(object sender, EventArgs e)
        {
            if (!PanelUploadTeacher.Controls.Contains(TeacherPage.instance))
            {
                PanelUploadTeacher.Controls.Add(TeacherPage.instance);
                TeacherPage.instance.Dock = DockStyle.Fill;
                TeacherPage.instance.BringToFront();

            }
            else
                TeacherPage.instance.BringToFront();


        }

        private void btnUploadGrade_Click(object sender, EventArgs e)
        {
            if (!PanelUploadTeacher.Controls.Contains(UploadGrade.instance))
            {
                PanelUploadTeacher.Controls.Add(UploadGrade.instance);
                UploadGrade.instance.Dock = DockStyle.Fill;
                UploadGrade.instance.BringToFront();

            }
            else
                UploadGrade.instance.BringToFront();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (!PanelUploadTeacher.Controls.Contains(UploadFile.instance))
            {
                PanelUploadTeacher.Controls.Add(UploadFile.instance);
                UploadFile.instance.Dock = DockStyle.Fill;
                UploadFile.instance.BringToFront();

            }
            else
                UploadFile.instance.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void TeachersPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

