
namespace projectuni1
{
    partial class AdminUpdate
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerHiredate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsModify = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblHiredate = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBloodG = new System.Windows.Forms.TextBox();
            this.lblBloodG = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminname = new System.Windows.Forms.TextBox();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerHiredate);
            this.panel1.Controls.Add(this.dataGridViewAdmin);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.lblHiredate);
            this.panel1.Controls.Add(this.txtDob);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtBloodG);
            this.panel1.Controls.Add(this.lblBloodG);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAdminPassword);
            this.panel1.Controls.Add(this.txtAdminname);
            this.panel1.Controls.Add(this.txtAdminId);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.lblDob);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.lblAdminId);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 675);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerHiredate
            // 
            this.dateTimePickerHiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHiredate.Location = new System.Drawing.Point(270, 416);
            this.dateTimePickerHiredate.Name = "dateTimePickerHiredate";
            this.dateTimePickerHiredate.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerHiredate.TabIndex = 91;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(563, 150);
            this.dataGridViewAdmin.TabIndex = 90;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsModify});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // cmsModify
            // 
            this.cmsModify.Name = "cmsModify";
            this.cmsModify.Size = new System.Drawing.Size(112, 22);
            this.cmsModify.Text = "Modify";
            this.cmsModify.Click += new System.EventHandler(this.cmsModify_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.Control;
            this.btnView.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnView.Location = new System.Drawing.Point(221, 149);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 33);
            this.btnView.TabIndex = 89;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalary.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(102, 444);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(65, 23);
            this.lblSalary.TabIndex = 87;
            this.lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtSalary.Location = new System.Drawing.Point(270, 444);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(187, 23);
            this.txtSalary.TabIndex = 86;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHiredate
            // 
            this.lblHiredate.AutoSize = true;
            this.lblHiredate.BackColor = System.Drawing.SystemColors.Control;
            this.lblHiredate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiredate.Location = new System.Drawing.Point(102, 414);
            this.lblHiredate.Name = "lblHiredate";
            this.lblHiredate.Size = new System.Drawing.Size(83, 23);
            this.lblHiredate.TabIndex = 84;
            this.lblHiredate.Text = "Hiredate:";
            // 
            // txtDob
            // 
            this.txtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDob.Location = new System.Drawing.Point(270, 310);
            this.txtDob.Multiline = true;
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(187, 23);
            this.txtDob.TabIndex = 83;
            this.txtDob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtGender.Location = new System.Drawing.Point(270, 349);
            this.txtGender.MaxLength = 6;
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(187, 23);
            this.txtGender.TabIndex = 82;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBloodG
            // 
            this.txtBloodG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodG.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBloodG.Location = new System.Drawing.Point(270, 383);
            this.txtBloodG.MaxLength = 3;
            this.txtBloodG.Multiline = true;
            this.txtBloodG.Name = "txtBloodG";
            this.txtBloodG.Size = new System.Drawing.Size(187, 23);
            this.txtBloodG.TabIndex = 81;
            this.txtBloodG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBloodG
            // 
            this.lblBloodG.AutoSize = true;
            this.lblBloodG.BackColor = System.Drawing.SystemColors.Control;
            this.lblBloodG.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodG.Location = new System.Drawing.Point(102, 378);
            this.lblBloodG.Name = "lblBloodG";
            this.lblBloodG.Size = new System.Drawing.Size(110, 23);
            this.lblBloodG.TabIndex = 80;
            this.lblBloodG.Text = "Blood group:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(307, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 79;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(149, 605);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 33);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(270, 473);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 59);
            this.txtAddress.TabIndex = 77;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPhone.Location = new System.Drawing.Point(270, 538);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(187, 23);
            this.txtPhone.TabIndex = 76;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(270, 275);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 23);
            this.txtEmail.TabIndex = 75;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAdminPassword.Location = new System.Drawing.Point(270, 246);
            this.txtAdminPassword.Multiline = true;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(187, 23);
            this.txtAdminPassword.TabIndex = 74;
            this.txtAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminname
            // 
            this.txtAdminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAdminname.Location = new System.Drawing.Point(270, 217);
            this.txtAdminname.Multiline = true;
            this.txtAdminname.Name = "txtAdminname";
            this.txtAdminname.Size = new System.Drawing.Size(187, 23);
            this.txtAdminname.TabIndex = 73;
            this.txtAdminname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminId
            // 
            this.txtAdminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAdminId.Location = new System.Drawing.Point(270, 188);
            this.txtAdminId.MaxLength = 6;
            this.txtAdminId.Multiline = true;
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.ReadOnly = true;
            this.txtAdminId.Size = new System.Drawing.Size(187, 23);
            this.txtAdminId.TabIndex = 72;
            this.txtAdminId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminId_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(102, 473);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 23);
            this.lblAddress.TabIndex = 71;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(102, 538);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(129, 23);
            this.lblPhoneNumber.TabIndex = 70;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.BackColor = System.Drawing.SystemColors.Control;
            this.lblDob.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(102, 309);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(112, 23);
            this.lblDob.TabIndex = 69;
            this.lblDob.Text = "Date of Birth:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.Control;
            this.lblGender.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(102, 348);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 23);
            this.lblGender.TabIndex = 68;
            this.lblGender.Text = "Gender:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(102, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 23);
            this.lblPassword.TabIndex = 67;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(102, 274);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 23);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminName.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(102, 217);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(111, 23);
            this.lblAdminName.TabIndex = 65;
            this.lblAdminName.Text = "Admin Name:";
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminId.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdminId.Location = new System.Drawing.Point(104, 187);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(81, 23);
            this.lblAdminId.TabIndex = 64;
            this.lblAdminId.Text = "Admin Id:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 674);
            this.Controls.Add(this.panel1);
            this.Name = "AdminUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUpdate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUpdate_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtBloodG;
        private System.Windows.Forms.Label lblBloodG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminname;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblHiredate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsModify;
        private System.Windows.Forms.DateTimePicker dateTimePickerHiredate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}