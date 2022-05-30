namespace projectuni1
{
    partial class TeachersPanel
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
            this.PanelUploadTeacher = new System.Windows.Forms.Panel();
            this.TeachersMenuPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnUploadGrade = new System.Windows.Forms.Button();
            this.TeachersMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUploadTeacher
            // 
            this.PanelUploadTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUploadTeacher.Location = new System.Drawing.Point(200, 0);
            this.PanelUploadTeacher.Name = "PanelUploadTeacher";
            this.PanelUploadTeacher.Size = new System.Drawing.Size(747, 525);
            this.PanelUploadTeacher.TabIndex = 5;
            // 
            // TeachersMenuPanel
            // 
            this.TeachersMenuPanel.Controls.Add(this.btnBack);
            this.TeachersMenuPanel.Controls.Add(this.btnUploadFile);
            this.TeachersMenuPanel.Controls.Add(this.btnUploadGrade);
            this.TeachersMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeachersMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.TeachersMenuPanel.Name = "TeachersMenuPanel";
            this.TeachersMenuPanel.Size = new System.Drawing.Size(200, 525);
            this.TeachersMenuPanel.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 86);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUploadFile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(0, 40);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(200, 46);
            this.btnUploadFile.TabIndex = 1;
            this.btnUploadFile.Text = "Upload File ";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnUploadGrade
            // 
            this.btnUploadGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUploadGrade.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadGrade.Location = new System.Drawing.Point(0, 0);
            this.btnUploadGrade.Name = "btnUploadGrade";
            this.btnUploadGrade.Size = new System.Drawing.Size(200, 40);
            this.btnUploadGrade.TabIndex = 0;
            this.btnUploadGrade.Text = "Upload Grade";
            this.btnUploadGrade.UseVisualStyleBackColor = true;
            this.btnUploadGrade.Click += new System.EventHandler(this.btnUploadGrade_Click);
            // 
            // TeachersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 525);
            this.Controls.Add(this.PanelUploadTeacher);
            this.Controls.Add(this.TeachersMenuPanel);
            this.Name = "TeachersPanel";
            this.Text = "TeachersPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachersPanel_FormClosing);
            this.Load += new System.EventHandler(this.Teachers_Panel_Load);
            this.TeachersMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelUploadTeacher;
        private System.Windows.Forms.Panel TeachersMenuPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnUploadGrade;
    }
}