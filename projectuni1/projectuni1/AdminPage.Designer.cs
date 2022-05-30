
namespace projectuni1
{
    partial class AdminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.viewStudentButton = new System.Windows.Forms.Button();
            this.viewTeacherButton = new System.Windows.Forms.Button();
            this.edtstudentButton = new System.Windows.Forms.Button();
            this.edtteacherButton = new System.Windows.Forms.Button();
            this.EdtstaffButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.viewStuffButton = new System.Windows.Forms.Button();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.updateAdminButton = new System.Windows.Forms.Button();
            this.adminInfoButton = new System.Windows.Forms.Button();
            this.dataGridViewSTSList = new System.Windows.Forms.DataGridView();
            this.dataGridViewAdminInfo = new System.Windows.Forms.DataGridView();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSTSList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.viewStudentButton);
            this.panel1.Controls.Add(this.viewTeacherButton);
            this.panel1.Controls.Add(this.edtstudentButton);
            this.panel1.Controls.Add(this.edtteacherButton);
            this.panel1.Controls.Add(this.EdtstaffButton);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.viewStuffButton);
            this.panel1.Controls.Add(this.deleteAdminButton);
            this.panel1.Controls.Add(this.updateAdminButton);
            this.panel1.Controls.Add(this.adminInfoButton);
            this.panel1.Controls.Add(this.dataGridViewSTSList);
            this.panel1.Controls.Add(this.dataGridViewAdminInfo);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Location = new System.Drawing.Point(-25, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 583);
            this.panel1.TabIndex = 2;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(37, 538);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(157, 35);
            this.btnAddCourse.TabIndex = 26;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // viewStudentButton
            // 
            this.viewStudentButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentButton.Location = new System.Drawing.Point(827, 497);
            this.viewStudentButton.Name = "viewStudentButton";
            this.viewStudentButton.Size = new System.Drawing.Size(155, 35);
            this.viewStudentButton.TabIndex = 23;
            this.viewStudentButton.Text = "View Student Info";
            this.viewStudentButton.UseVisualStyleBackColor = false;
            this.viewStudentButton.Click += new System.EventHandler(this.viewStudentButton_Click);
            // 
            // viewTeacherButton
            // 
            this.viewTeacherButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewTeacherButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeacherButton.Location = new System.Drawing.Point(620, 497);
            this.viewTeacherButton.Name = "viewTeacherButton";
            this.viewTeacherButton.Size = new System.Drawing.Size(157, 35);
            this.viewTeacherButton.TabIndex = 22;
            this.viewTeacherButton.Text = "View Teacher Info";
            this.viewTeacherButton.UseVisualStyleBackColor = false;
            this.viewTeacherButton.Click += new System.EventHandler(this.viewTeacherButton_Click);
            // 
            // edtstudentButton
            // 
            this.edtstudentButton.BackColor = System.Drawing.SystemColors.Control;
            this.edtstudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtstudentButton.Location = new System.Drawing.Point(827, 538);
            this.edtstudentButton.Name = "edtstudentButton";
            this.edtstudentButton.Size = new System.Drawing.Size(155, 35);
            this.edtstudentButton.TabIndex = 16;
            this.edtstudentButton.Text = "Edit Student";
            this.edtstudentButton.UseVisualStyleBackColor = false;
            this.edtstudentButton.Click += new System.EventHandler(this.edtstudentButton_Click);
            // 
            // edtteacherButton
            // 
            this.edtteacherButton.BackColor = System.Drawing.SystemColors.Control;
            this.edtteacherButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtteacherButton.Location = new System.Drawing.Point(620, 538);
            this.edtteacherButton.Name = "edtteacherButton";
            this.edtteacherButton.Size = new System.Drawing.Size(157, 35);
            this.edtteacherButton.TabIndex = 13;
            this.edtteacherButton.Text = "Edit Teacher";
            this.edtteacherButton.UseVisualStyleBackColor = false;
            this.edtteacherButton.Click += new System.EventHandler(this.edtteacherButton_Click);
            // 
            // EdtstaffButton
            // 
            this.EdtstaffButton.BackColor = System.Drawing.SystemColors.Control;
            this.EdtstaffButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdtstaffButton.Location = new System.Drawing.Point(425, 538);
            this.EdtstaffButton.Name = "EdtstaffButton";
            this.EdtstaffButton.Size = new System.Drawing.Size(157, 35);
            this.EdtstaffButton.TabIndex = 12;
            this.EdtstaffButton.Text = "Edit Staff";
            this.EdtstaffButton.UseVisualStyleBackColor = false;
            this.EdtstaffButton.Click += new System.EventHandler(this.EdtstaffButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(153, 391);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(149, 35);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // viewStuffButton
            // 
            this.viewStuffButton.BackColor = System.Drawing.SystemColors.Control;
            this.viewStuffButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStuffButton.Location = new System.Drawing.Point(425, 497);
            this.viewStuffButton.Name = "viewStuffButton";
            this.viewStuffButton.Size = new System.Drawing.Size(157, 35);
            this.viewStuffButton.TabIndex = 10;
            this.viewStuffButton.Text = "View Stuff Info";
            this.viewStuffButton.UseVisualStyleBackColor = false;
            this.viewStuffButton.Click += new System.EventHandler(this.viewStuffButton_Click);
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteAdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdminButton.Location = new System.Drawing.Point(156, 350);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(146, 35);
            this.deleteAdminButton.TabIndex = 9;
            this.deleteAdminButton.Text = "Delete Admin";
            this.deleteAdminButton.UseVisualStyleBackColor = false;
            this.deleteAdminButton.Click += new System.EventHandler(this.deleteAdminButton_Click);
            // 
            // updateAdminButton
            // 
            this.updateAdminButton.BackColor = System.Drawing.SystemColors.Control;
            this.updateAdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdminButton.Location = new System.Drawing.Point(156, 309);
            this.updateAdminButton.Name = "updateAdminButton";
            this.updateAdminButton.Size = new System.Drawing.Size(146, 35);
            this.updateAdminButton.TabIndex = 8;
            this.updateAdminButton.Text = "Update Admin";
            this.updateAdminButton.UseVisualStyleBackColor = false;
            this.updateAdminButton.Click += new System.EventHandler(this.updateAdminButton_Click);
            // 
            // adminInfoButton
            // 
            this.adminInfoButton.BackColor = System.Drawing.SystemColors.Control;
            this.adminInfoButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInfoButton.Location = new System.Drawing.Point(156, 268);
            this.adminInfoButton.Name = "adminInfoButton";
            this.adminInfoButton.Size = new System.Drawing.Size(146, 35);
            this.adminInfoButton.TabIndex = 5;
            this.adminInfoButton.Text = "View Admin Info";
            this.adminInfoButton.UseVisualStyleBackColor = false;
            this.adminInfoButton.Click += new System.EventHandler(this.adminInfoButton_Click);
            // 
            // dataGridViewSTSList
            // 
            this.dataGridViewSTSList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSTSList.Location = new System.Drawing.Point(408, 268);
            this.dataGridViewSTSList.Name = "dataGridViewSTSList";
            this.dataGridViewSTSList.Size = new System.Drawing.Size(574, 223);
            this.dataGridViewSTSList.TabIndex = 4;
            // 
            // dataGridViewAdminInfo
            // 
            this.dataGridViewAdminInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminInfo.Location = new System.Drawing.Point(16, 48);
            this.dataGridViewAdminInfo.Name = "dataGridViewAdminInfo";
            this.dataGridViewAdminInfo.Size = new System.Drawing.Size(979, 214);
            this.dataGridViewAdminInfo.TabIndex = 1;
            this.dataGridViewAdminInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminInfo_CellContentClick);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(402, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(143, 36);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 584);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSTSList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewStudentButton;
        private System.Windows.Forms.Button viewTeacherButton;
        private System.Windows.Forms.Button edtstudentButton;
        private System.Windows.Forms.Button edtteacherButton;
        private System.Windows.Forms.Button EdtstaffButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button viewStuffButton;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.Button updateAdminButton;
        private System.Windows.Forms.Button adminInfoButton;
        private System.Windows.Forms.DataGridView dataGridViewSTSList;
        private System.Windows.Forms.DataGridView dataGridViewAdminInfo;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button btnAddCourse;
    }
}