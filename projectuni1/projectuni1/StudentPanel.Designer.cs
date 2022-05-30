
namespace projectuni1
{
    partial class StudentPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeachersMenuPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStudyMetarial = new System.Windows.Forms.Button();
            this.btnRequestCourse = new System.Windows.Forms.Button();
            this.btnViewGrade = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.panelStudentHomepage = new System.Windows.Forms.Panel();
            this.TeachersMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeachersMenuPanel
            // 
            this.TeachersMenuPanel.Controls.Add(this.btnLogout);
            this.TeachersMenuPanel.Controls.Add(this.btnStudyMetarial);
            this.TeachersMenuPanel.Controls.Add(this.btnRequestCourse);
            this.TeachersMenuPanel.Controls.Add(this.btnViewGrade);
            this.TeachersMenuPanel.Controls.Add(this.btnViewProfile);
            this.TeachersMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeachersMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.TeachersMenuPanel.Name = "TeachersMenuPanel";
            this.TeachersMenuPanel.Size = new System.Drawing.Size(200, 673);
            this.TeachersMenuPanel.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 160);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 37);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStudyMetarial
            // 
            this.btnStudyMetarial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudyMetarial.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudyMetarial.Location = new System.Drawing.Point(0, 123);
            this.btnStudyMetarial.Name = "btnStudyMetarial";
            this.btnStudyMetarial.Size = new System.Drawing.Size(200, 37);
            this.btnStudyMetarial.TabIndex = 4;
            this.btnStudyMetarial.Text = "Files";
            this.btnStudyMetarial.UseVisualStyleBackColor = true;
            this.btnStudyMetarial.Click += new System.EventHandler(this.btnStudyMetarial_Click);
            // 
            // btnRequestCourse
            // 
            this.btnRequestCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequestCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCourse.Location = new System.Drawing.Point(0, 86);
            this.btnRequestCourse.Name = "btnRequestCourse";
            this.btnRequestCourse.Size = new System.Drawing.Size(200, 37);
            this.btnRequestCourse.TabIndex = 3;
            this.btnRequestCourse.Text = "Request Course";
            this.btnRequestCourse.UseVisualStyleBackColor = true;
            this.btnRequestCourse.Click += new System.EventHandler(this.btnRequestCourse_Click);
            // 
            // btnViewGrade
            // 
            this.btnViewGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewGrade.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGrade.Location = new System.Drawing.Point(0, 40);
            this.btnViewGrade.Name = "btnViewGrade";
            this.btnViewGrade.Size = new System.Drawing.Size(200, 46);
            this.btnViewGrade.TabIndex = 1;
            this.btnViewGrade.Text = "Show Grade";
            this.btnViewGrade.UseVisualStyleBackColor = true;
            this.btnViewGrade.Click += new System.EventHandler(this.btnViewGrade_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(0, 0);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(200, 40);
            this.btnViewProfile.TabIndex = 0;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // panelStudentHomepage
            // 
            this.panelStudentHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentHomepage.Location = new System.Drawing.Point(200, 0);
            this.panelStudentHomepage.Name = "panelStudentHomepage";
            this.panelStudentHomepage.Size = new System.Drawing.Size(607, 673);
            this.panelStudentHomepage.TabIndex = 8;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 673);
            this.Controls.Add(this.panelStudentHomepage);
            this.Controls.Add(this.TeachersMenuPanel);
            this.Name = "StudentPanel";
            this.Text = "StudentPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPanel_FormClosing);
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            this.TeachersMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TeachersMenuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStudyMetarial;
        private System.Windows.Forms.Button btnRequestCourse;
        private System.Windows.Forms.Button btnViewGrade;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Panel panelStudentHomepage;
    }
}