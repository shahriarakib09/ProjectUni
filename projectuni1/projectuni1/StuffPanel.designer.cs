namespace projectuni1
{
    partial class StuffPanel
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
            this.panelStuffHomePage = new System.Windows.Forms.Panel();
            this.TeachersMenuPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAssignCourse = new System.Windows.Forms.Button();
            this.btnViewRequest = new System.Windows.Forms.Button();
            this.TeachersMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStuffHomePage
            // 
            this.panelStuffHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStuffHomePage.Location = new System.Drawing.Point(200, 0);
            this.panelStuffHomePage.Name = "panelStuffHomePage";
            this.panelStuffHomePage.Size = new System.Drawing.Size(600, 450);
            this.panelStuffHomePage.TabIndex = 7;
            // 
            // TeachersMenuPanel
            // 
            this.TeachersMenuPanel.Controls.Add(this.btnLogout);
            this.TeachersMenuPanel.Controls.Add(this.btnAssignCourse);
            this.TeachersMenuPanel.Controls.Add(this.btnViewRequest);
            this.TeachersMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeachersMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.TeachersMenuPanel.Name = "TeachersMenuPanel";
            this.TeachersMenuPanel.Size = new System.Drawing.Size(200, 450);
            this.TeachersMenuPanel.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 86);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignCourse.Location = new System.Drawing.Point(0, 40);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.Size = new System.Drawing.Size(200, 46);
            this.btnAssignCourse.TabIndex = 1;
            this.btnAssignCourse.Text = "Assign A Course";
            this.btnAssignCourse.UseVisualStyleBackColor = true;
            this.btnAssignCourse.Click += new System.EventHandler(this.btnAssignCourse_Click);
            // 
            // btnViewRequest
            // 
            this.btnViewRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewRequest.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRequest.Location = new System.Drawing.Point(0, 0);
            this.btnViewRequest.Name = "btnViewRequest";
            this.btnViewRequest.Size = new System.Drawing.Size(200, 40);
            this.btnViewRequest.TabIndex = 0;
            this.btnViewRequest.Text = "View Request";
            this.btnViewRequest.UseVisualStyleBackColor = true;
            this.btnViewRequest.Click += new System.EventHandler(this.btnViewRequest_Click);
            // 
            // StuffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStuffHomePage);
            this.Controls.Add(this.TeachersMenuPanel);
            this.Name = "StuffPanel";
            this.Text = "StuffPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StuffPanel_FormClosing);
            this.Load += new System.EventHandler(this.StuffPanel_Load);
            this.TeachersMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStuffHomePage;
        private System.Windows.Forms.Panel TeachersMenuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAssignCourse;
        private System.Windows.Forms.Button btnViewRequest;
    }
}