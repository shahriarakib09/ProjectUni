
namespace projectuni1
{
    partial class Login
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
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginAsAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loginAsAdminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loginAsStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loginAsTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.loginAsStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(49, 59);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(64, 16);
            this.labelUserId.TabIndex = 0;
            this.labelUserId.Text = "Admin Id :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(49, 99);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 16);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password :";
            // 
            // txtAdminId
            // 
            this.txtAdminId.Location = new System.Drawing.Point(117, 57);
            this.txtAdminId.MaxLength = 6;
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(123, 20);
            this.txtAdminId.TabIndex = 2;
            this.txtAdminId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminId_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(123, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(94, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 26);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(94, 247);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(126, 26);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginAsAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginAsAdminToolStripMenuItem
            // 
            this.loginAsAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.loginAsAdminToolStripMenuItem1,
            this.toolStripSeparator2,
            this.loginAsStuffToolStripMenuItem,
            this.toolStripSeparator3,
            this.loginAsTeacherToolStripMenuItem,
            this.toolStripSeparator4,
            this.loginAsStudentToolStripMenuItem});
            this.loginAsAdminToolStripMenuItem.Name = "loginAsAdminToolStripMenuItem";
            this.loginAsAdminToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.loginAsAdminToolStripMenuItem.Text = "Login Option";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // loginAsAdminToolStripMenuItem1
            // 
            this.loginAsAdminToolStripMenuItem1.Name = "loginAsAdminToolStripMenuItem1";
            this.loginAsAdminToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loginAsAdminToolStripMenuItem1.Text = "Login as admin";
            this.loginAsAdminToolStripMenuItem1.Click += new System.EventHandler(this.loginAsAdminToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // loginAsStuffToolStripMenuItem
            // 
            this.loginAsStuffToolStripMenuItem.Name = "loginAsStuffToolStripMenuItem";
            this.loginAsStuffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginAsStuffToolStripMenuItem.Text = "Login as stuff";
            this.loginAsStuffToolStripMenuItem.Click += new System.EventHandler(this.loginAsStuffToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // loginAsTeacherToolStripMenuItem
            // 
            this.loginAsTeacherToolStripMenuItem.Name = "loginAsTeacherToolStripMenuItem";
            this.loginAsTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginAsTeacherToolStripMenuItem.Text = "Login as Teacher";
            this.loginAsTeacherToolStripMenuItem.Click += new System.EventHandler(this.loginAsTeacherToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // loginAsStudentToolStripMenuItem
            // 
            this.loginAsStudentToolStripMenuItem.Name = "loginAsStudentToolStripMenuItem";
            this.loginAsStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginAsStudentToolStripMenuItem.Text = "Login as Student";
            this.loginAsStudentToolStripMenuItem.Click += new System.EventHandler(this.loginAsStudentToolStripMenuItem_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 426);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAdminId);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginAsAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loginAsAdminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem loginAsStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loginAsTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem loginAsStudentToolStripMenuItem;
    }
}

